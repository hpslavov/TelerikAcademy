using System;
class Program
{
    static void Main()
    {
        //Declare five variables choosing for each of them the most appropriate of the types
        //byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
        ushort ushortVariable = 52130;
        sbyte sbyteVariable = -115;
        int intVariable = 4825932;
        byte byteVariable = 97;
        short shortVariable = -10000;
        Console.WriteLine("{0} \n{1} \n{2} \n{3} \n{4}",ushortVariable,sbyteVariable,intVariable,byteVariable,shortVariable);
    }
}
