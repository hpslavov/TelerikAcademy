using System.Web.Mvc;

namespace BitCalculator.Areas.Calculator
{
    public class CalculatorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Calculator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                name: "Calculator_default",
                url: "Calculator/{controller}/{action}/{id}",
                defaults: new { action = "Index", id = UrlParameter.Optional },
                    namespaces: new[] { "BitCalculator.Areas.Calculator.Controllers" }

            );
        }
    }
}