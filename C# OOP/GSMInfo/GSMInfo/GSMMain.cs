using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMInfo;
namespace GSMInfo
{
    class GSMMain
    {
        static void Main(string[] args)
        {
            string newPhoneModel = "S4";
            string newPhoneManuf = "Samsung";
            GSMInfo newPhone = new GSMInfo(newPhoneModel, newPhoneManuf);//Base values added. Base values printed
            Console.WriteLine(newPhone);
            //Please adjust device characteristics.

            GSMCallHistoryTest gsm = new GSMCallHistoryTest();

            gsm.CallHistoryTest(5);
            Console.WriteLine(gsm);


        }
    }
}
