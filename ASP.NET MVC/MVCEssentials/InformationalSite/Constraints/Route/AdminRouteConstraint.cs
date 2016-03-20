using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Routing;

namespace InformationalSite.Constraints.Route
{
    public class AdminRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, System.Web.Routing.Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            ///^Admin(.)+/
            var pattern = "^Admin";
            var controllerName = values["controller"].ToString();
            var result = Regex.IsMatch(controllerName, pattern);
            return result;
        }
         
        
    }
}