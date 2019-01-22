using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.Models
{
    public class CalculatorModel
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Input { get; set; }
        public string OutputAll { get; set; }
        public string OutputEven { get; set; }
        public string OutputOdd { get; set; }
        public string OutputCondition { get; set; }
    }
}
