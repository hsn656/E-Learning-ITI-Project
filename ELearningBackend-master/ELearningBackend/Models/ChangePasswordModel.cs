using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class ChangePasswordModel
    {
        [Required, MaxLength(100)]
        public string UserId { get; set; }

        [Required, MaxLength(100)]
        public string CurrentPassword { get; set; }

        [Required, MaxLength(100)]
        public string NewPassword { get; set; }

    }

    public class ChangeEmailModel
    {
        [Required, MaxLength(100)]
        public string UserId { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
