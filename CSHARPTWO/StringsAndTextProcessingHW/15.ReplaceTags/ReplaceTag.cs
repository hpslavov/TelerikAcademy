using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _15.ReplaceTags
{
    class ReplaceTag
    {
        //Write a program that replaces in a HTML document
        //given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

        //Example:<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
        //Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

        //<p>Please visit [URL= http://academy.telerik.com ]our site[/URL] to choose a training course.
        //Also visit [URL= https://www.devbg.org ]our forum[/URL] to discuss the courses.</p>

        static void Main()
        {
            string input = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

            Console.WriteLine(Regex.Replace(input, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]"));
        }

    }
}
