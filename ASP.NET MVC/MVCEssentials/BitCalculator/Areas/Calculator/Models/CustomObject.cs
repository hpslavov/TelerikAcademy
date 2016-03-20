namespace BitCalculator.Areas.Calculator.Models
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class CustomObject
    {
        public int InputNumber { get; set; }
        public double ResultNumber { get; set; }
        public List<SelectListItem> Options { get; set; }
        public string SelectedOption { get; set; }

    }
}