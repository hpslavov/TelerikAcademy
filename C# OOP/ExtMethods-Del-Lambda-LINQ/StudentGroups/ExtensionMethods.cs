using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public static class ExtensionMethods
    {
        public static IEnumerable<Student> ExSortByTwoMarks(this IEnumerable<Student> students)
        {
            var filtered =
                from stud in students
                where stud.Marks.Count == 2
                select stud;
            return filtered;
        }

        public static IEnumerable<Student> ExtensionSortByGroup(this IEnumerable<Student> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            return sorted;
        }
    }
}
