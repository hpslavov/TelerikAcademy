
namespace BitCalculator.Areas.Calculator.Controllers
{
    using BitCalculator.Areas.Calculator.Models;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var options = new List<SelectListItem>()
              {
                new SelectListItem { Text =DataFormat.bit.ToString(), Value = DataFormat.bit + "" },
                new SelectListItem { Text = DataFormat.Byte.ToString(), Value = DataFormat.Byte + "" },
                new SelectListItem { Text = DataFormat.Kilobit.ToString(), Value = DataFormat.Kilobit + "" },
                new SelectListItem { Text = DataFormat.Kilobyte.ToString(), Value = DataFormat.Kilobyte + "" },
                new SelectListItem { Text = DataFormat.Megabit.ToString(), Value = DataFormat.Megabit + "" },
                new SelectListItem { Text = DataFormat.Megabyte.ToString(), Value = DataFormat.Megabyte + ""},
                new SelectListItem { Text = DataFormat.Terabit.ToString(), Value = DataFormat.Terabit + ""},
                new SelectListItem { Text = DataFormat.Terabyte.ToString(), Value = DataFormat.Terabyte + "" },
            };
            var model = new CustomObject
            {
                Options = options
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CustomObject customObject)
        {
            return this.RedirectToAction("Result", customObject);
        }

        public ActionResult Result(CustomObject customObject)
        {
            var result = CalculateResults(customObject);
            return View(result);
        }

        private ResultObjectModel CalculateResults(CustomObject obj)
        {
            var result = new ResultObjectModel();
            var currentValue = (decimal)obj.InputNumber;
            var currentOption = obj.SelectedOption;
            result.Input = (int)currentValue;
            result.Option = obj.SelectedOption;
            switch (currentOption)
            {
                case "bit":
                    result.Bit = currentValue;
                    result.Byte = currentValue * 8;
                    result.KiloBit = (currentValue / 1024);
                    result.KiloByte = (currentValue / 8192);
                    result.MegaBit = (currentValue / 1048576);
                    result.MegaByte = (currentValue / 8388608);
                    result.GigaBit = (currentValue / 1073741824);
                    result.GigaByte = (currentValue / 8589934592);
                    result.TeraBit = (currentValue / 1099511627776);
                    result.TeraByte = (currentValue / 8796093022208);
                    break;
                case "Byte":
                    result.Bit = (currentValue * 8);
                    result.Byte = currentValue;
                    result.KiloBit = (currentValue / 128);
                    result.KiloByte = (currentValue / 1024);
                    result.MegaBit = (currentValue / 131072);
                    result.MegaByte = (currentValue / 1048576);
                    result.GigaBit = (currentValue / 1073741824);
                    result.GigaByte = (currentValue / 8589934592);
                    result.TeraBit = (currentValue / 1099511627776);
                    result.TeraByte = (currentValue / 8796093022208);
                    break;
                case "Kilobit":
                    result.Bit = currentValue * 1024;
                    result.Byte = currentValue * 128;
                    result.KiloBit = currentValue;
                    result.KiloByte = (currentValue / 8);
                    result.MegaBit = (currentValue / 1024);
                    result.MegaByte = (currentValue / 8192);
                    result.GigaBit = (currentValue / 134217728);
                    result.GigaByte = (currentValue / 1073741824);
                    result.TeraBit = (currentValue / 137438953472);
                    result.TeraByte = (currentValue / 1099511627776);
                    break;
                case "Kilobyte":
                    result.Bit = currentValue * 8192;
                    result.Byte = currentValue * 1024;
                    result.KiloBit = currentValue * 8;
                    result.KiloByte = currentValue;
                    result.MegaBit = (currentValue / 8);
                    result.MegaByte = (currentValue / 1024);
                    result.GigaBit = (currentValue / 131072);
                    result.GigaByte = (currentValue / 1048576);
                    result.TeraBit = (currentValue / 134217728);
                    result.TeraByte = (currentValue / 1073741824);
                    break;
                case "Megabit":
                    result.Bit = currentValue * 1048576;
                    result.Byte = currentValue * 131072;
                    result.KiloBit = currentValue * 1024;
                    result.KiloByte = currentValue * 128;
                    result.MegaBit = currentValue;
                    result.MegaByte = (currentValue / 8);
                    result.GigaBit = (currentValue / 1024);
                    result.GigaByte = (currentValue / 8192);
                    result.TeraBit = (currentValue / 1048576);
                    result.TeraByte = (currentValue / 8388608);
                    break;
                case "Megabyte":
                    result.Bit = currentValue * 8388608;
                    result.Byte = currentValue * 1048576;
                    result.KiloBit = currentValue * 8192;
                    result.KiloByte = currentValue * 1024;
                    result.MegaBit = currentValue * 8;
                    result.MegaByte = currentValue;
                    result.GigaBit = (currentValue / 128);
                    result.GigaByte = (currentValue / 1024);
                    result.TeraBit = (currentValue / 131072);
                    result.TeraByte = (currentValue / 1048576);
                    break;
                case "Gigabit":
                    break;
                case "Gigabyte":
                    break;
                case "Terabit":
                    break;
                case "Terabyte":
                    break;
                default:
                    break;
            }


            return result;
        }
    }
}