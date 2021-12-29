using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class Option
    {

        public int OptionId { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }

        [ForeignKey("Question")]
        [JsonIgnore]
        public int QuestionId { get; set; }

        [JsonIgnore]
        public  Question Question { get; set; }
    }
}
