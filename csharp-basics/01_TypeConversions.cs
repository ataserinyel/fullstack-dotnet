using System;

public class TypeConversions
{
    public static void FuncTypeConversions()
    {
        Console.WriteLine("Type Conversions:");

        int x = 5;
        long y;
        y = x;  // Implicit
        Console.WriteLine(y);

        long a = 12948112;
        x = (int)a; // Explicit
        Console.WriteLine(x);

        float k = 7.4f;
        int l;
        l = (int)k;
        Console.WriteLine(l);

        int varNum = 50;
        bool varBool = true;

        Console.WriteLine(Convert.ToString(varNum));
        Console.WriteLine(Convert.ToString(varBool));
        Console.WriteLine(Convert.ToInt32(varBool));

    }
}