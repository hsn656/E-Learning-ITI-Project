using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.DTOs
{
    public class OptionsDTO
    {
        public int OptionId { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
    }
}
