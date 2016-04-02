namespace GSMInfo
{
    using System;
    class GSMTest
    {
        public void TestGsm(int gsmTests)
        {
            GSMInfo[] phones = new GSMInfo[gsmTests];

            for (int i = 0; i < gsmTests; i++)
            {
                phones[i] = new GSMInfo("Model" + (i + 1),"Manufacturer" + (i + 1),"Owner" + (i + 1),0 + (i + 1));

                Console.WriteLine(phones[i]);
            }

            GSMInfo Iphone = new GSMInfo("Iphone4S", "Apple");
            Console.WriteLine(Iphone.Iphone4SInfo);
        }
    }
}
