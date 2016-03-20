namespace RssFeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Feeder
    {
        public static void Main(string[] args)
        {
            var feeder = new RssFeederXml();
            var result = feeder.ReadRss();

            Console.WriteLine(result);
        }
    }
}
