using System;

public class Arrays
{
    public static void FuncArrays()
    {
        Console.WriteLine("Arrays (1d):");

        int[] nullArray = new int[5];
        Console.WriteLine(nullArray[0]);
        Console.WriteLine(nullArray[1]);
        Console.WriteLine(nullArray[2]);
        Console.WriteLine(nullArray[3]);
        Console.WriteLine(nullArray[4]);

        int[] newArray = { 4, 7, 0, -5, 99 };
        Console.WriteLine(newArray[0]);
        Console.WriteLine(newArray[1]);
        Console.WriteLine(newArray[2]);
        Console.WriteLine(newArray[3]);
        Console.WriteLine(newArray[4]);

        string[] newArray2 = { "Ata", "Naz", "Ece", "Zeynep", "Kudret", "Ali" };
        Console.WriteLine(newArray2[0]);
        Console.WriteLine(newArray2[1]);
        Console.WriteLine(newArray2[2]);
        Console.WriteLine(newArray2[3]);
        Console.WriteLine(newArray2[4]);
        Console.WriteLine(newArray2[5]);


        Console.WriteLine("\nArrays (2d):");

        int[,] newArray2d = { { 4, 7 }, { 5, 8 } };
        Console.WriteLine($"{newArray2d[0, 0]} - {newArray2d[0, 1]}");
        Console.WriteLine($"{newArray2d[1, 0]} - {newArray2d[1, 1]}");


        Console.WriteLine("\nArrays (3d):");

        string[,,] newArray3d = { { { "Ata", "Naz" }, { "Zeynep", "Ece" } }, { { "Ata", "Ece" }, { "Naz", "Zeynep" } } };
        Console.WriteLine($"{newArray3d[0, 0, 0]} - {newArray3d[0, 0, 1]}");
        Console.WriteLine($"{newArray3d[0, 1, 0]} - {newArray3d[0, 1, 1]}");
        Console.WriteLine($"{newArray3d[1, 0, 0]} - {newArray3d[1, 0, 1]}");
        Console.WriteLine($"{newArray3d[1, 1, 0]} - {newArray3d[1, 1, 1]}");

    }
}