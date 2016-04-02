namespace _18.GroupGrouping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public static class Methods
    {
       public static IEnumerable<Student> GroupingGroups(this IEnumerable<Student> groups)//task 19
       {
           return groups.OrderBy(x => x.Group);
       }
    }
}
