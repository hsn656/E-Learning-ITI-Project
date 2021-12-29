using ELearningBackend.Helpers;
using ELearningBackend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ELearningBackend.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JWT _jwt;

        public AuthService(UserManager<ApplicationUser> userManager, IOptions<JWT> jwt)
        {
            _userManager = userManager;
            _jwt = jwt.Value;
        }
        public async Task<AuthModel> RegisterAsync(RegisterModel model)
        {
            if (await _userManager.FindByEmailAsync(model.Email) is not null)
                return new AuthModel() { Message = "هذا البريد الإلكتروني موجود بالفعل", IsAuthinticated = false };


            var user = new ApplicationUser()
            {
                UserName = model.Email,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
            };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                var Msg = string.Empty;
                foreach (var err in result.Errors)
                {
                    Msg += $"{err.Description},";
                }
                return new AuthModel() { Message = Msg, IsAuthinticated = false };
            }

            await _userManager.AddToRoleAsync(user, "Bronze");

            var JwtSecurityToken = await CreateJwtTokenAsync(user);

            return new AuthModel()
            {
                Id=user.Id,
                Email = user.Email,
                ExpiresOn = JwtSecurityToken.ValidTo,
                IsAuthinticated = true,
                Roles = new List<string> { "Bronze" },
                Token = new JwtSecurityTokenHandler().WriteToken(JwtSecurityToken),
            };
        }

        public async Task<JwtSecurityToken> CreateJwtTokenAsync(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = new List<Claim>();

            foreach (var role in roles)
            {
                roleClaims.Add(new Claim("roles", role));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim("uid",user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.Now.AddDays(_jwt.DurationInDays),
                signingCredentials: signingCredentials
                );

            return jwtSecurityToken;
        }

        public async Task<AuthModel> GetTokenAsync(TokentRequesModel model)
        {
            var authModel = new AuthModel();
            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user is null || !await _userManager.CheckPasswordAsync(user,model.Password))
            {
                authModel.Message = "البريد الإلكتروني أو كلمة السر غير صحيح";
                authModel.IsAuthinticated = false;
                return authModel;
            }

            var token = await  CreateJwtTokenAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            authModel.Id = user.Id;
            authModel.Email = user.Email;
            authModel.ExpiresOn = token.ValidTo;
            authModel.IsAuthinticated = true;
            authModel.Roles = roles.ToList();
            authModel.Token = new JwtSecurityTokenHandler().WriteToken(token);

            return authModel;
        }

        public async Task<bool> ChangePasswordAsync(ChangePasswordModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if(!(user is null))
            {
                try
                {
                    var tt = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                    if (tt.Succeeded)
                        return true;
                    else
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public async Task<bool> ChangeEmaildAsync(ChangeEmailModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (!(user is null))
            {
                var ss = await _userManager.SetEmailAsync(user, model.Email);
                if (ss.Succeeded)
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}
