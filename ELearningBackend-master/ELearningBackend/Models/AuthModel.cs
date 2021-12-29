using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{

    [NotMapped]
    public class AuthModel
    {
        [NotMapped]
        public string Id { get; set; }
        public string Message { get; set; }
        public bool IsAuthinticated { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }

    }
}
