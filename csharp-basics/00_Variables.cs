using System;

public class Variables
{
    public static void FuncVariables()
    {
        Console.WriteLine("Print Types:");

        int luckyNum = 4;
        Console.WriteLine("Var 1: My lucky num is: " + luckyNum);
        Console.WriteLine($"Var 2: My lucky num is: {luckyNum}");
        Console.WriteLine("Var 3: My lucky num is: {0}\n", luckyNum);


        Console.WriteLine("Integer Variables:");

        byte maxByte = 255;
        byte minByte = 0;
        Console.WriteLine($"Max BYTE {maxByte} | Min BYTE {minByte}");

        sbyte maxSbyte = 127;
        sbyte minSbyte = -128;
        Console.WriteLine($"Max SBYTE {maxSbyte} | Min SBYTE {minSbyte}");

        short maxShort = 32767;
        short minShort = -32768;
        Console.WriteLine($"Max SHORT {maxShort} | Min SHORT {minShort}");

        ushort maxUshort = 32767;
        ushort minUshort = 0;
        Console.WriteLine($"Max USHORT {maxUshort} | Min USHORT {minUshort}");

        int maxInt = 2147483647;
        int minInt = -2147483647;
        Console.WriteLine($"Max INT {maxInt} | Min INT {minInt}");

        uint maxUint = 4294967295u;
        uint minUint = 0u;
        Console.WriteLine($"Max UINT {maxUint} | Min UINT {minUint}");

        long maxLong = 9223372036854775807L;
        long minLong = -9223372036854775808L;
        Console.WriteLine($"Max LONG {maxLong} | Min LONG {minLong}");

        ulong maxUlong = 18446744073709551615uL;
        ulong minUlong = 0uL;
        Console.WriteLine($"Max ULONG {maxUlong} | Min ULONG {minUlong}\n");


        Console.WriteLine("Other Variables:");

        float luckyFloat = 4.2f;
        Console.WriteLine($"Lucky Float: {luckyFloat}");

        double luckyDouble = 4.2;
        Console.WriteLine($"Lucky Double: {luckyDouble}");

        decimal luckyDecimal = 19.99m;
        Console.WriteLine($"Lucky Decimal: {luckyDecimal}");

        char luckyChar = 'a';
        Console.WriteLine($"Lucky Char: {luckyChar}");

        string luckyString = "Ata Serinyel";
        Console.WriteLine($"Lucky String: {luckyString}");

        bool luckyBool = false;
        Console.WriteLine($"Lucky Bool: {luckyBool}");

        object luckyObject1 = "Luck Object";
        object luckyObject2 = 4;
        Console.WriteLine($"{luckyObject1} is {luckyObject2}");

        DateTime dateTime = DateTime.Now;
        Console.WriteLine($"{dateTime}\n");
    }
}