using System;

public class Operators
{
    public static void FuncOperators()
    {
        Console.WriteLine("Operators:");

        int a = 30, b = 2;

        int result = a + b;
        Console.WriteLine($"{a} + {b} = {result}");

        int result2 = a - b;
        Console.WriteLine($"{a} - {b} = {result2}");

        int result3 = a * b;
        Console.WriteLine($"{a} * {b} = {result3}");

        int result4 = a / b;
        Console.WriteLine($"{a} / {b} = {result4}");

        int result5 = a % b;
        Console.WriteLine($"{a} % {b} = {result5}");


        Console.WriteLine($"{a}++ -> {++a}");
        Console.WriteLine($"{b}-- = {--b}");

    }
}