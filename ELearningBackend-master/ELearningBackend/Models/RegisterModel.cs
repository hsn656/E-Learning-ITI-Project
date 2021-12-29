using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class RegisterModel
    {
        [Required,MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required,MaxLength(50)]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(200)]
        public string Email { get; set; }

        [Required, MaxLength(100)]
        public string Password { get; set; }
    }
}
