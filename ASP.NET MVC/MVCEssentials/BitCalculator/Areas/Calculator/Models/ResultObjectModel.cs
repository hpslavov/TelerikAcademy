using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCalculator.Areas.Calculator.Models
{
    public class ResultObjectModel
    {
        public int Input { get; set; }
        public string Option { get; set; }
        public decimal Bit { get; set; }
        public decimal Byte { get; set; }
        public decimal KiloBit { get; set; }
        public decimal KiloByte { get; set; }
        public decimal MegaBit { get; set; }
        public decimal MegaByte { get; set; }
        public decimal GigaBit { get; set; }
        public decimal GigaByte { get; set; }
        public decimal TeraBit { get; set; }
        public decimal TeraByte { get; set; }
    }
}