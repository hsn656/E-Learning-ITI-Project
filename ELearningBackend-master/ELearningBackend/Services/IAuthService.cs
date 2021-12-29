using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokentRequesModel model);
        Task<bool> ChangePasswordAsync(ChangePasswordModel model);
        Task<bool> ChangeEmaildAsync(ChangeEmailModel model);
    }
}
