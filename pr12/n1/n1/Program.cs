using System;

public static class Calculator
{
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            return 0;
        }
        return a / b;
    }
}

class ProgramCalculator
{
    static void Main()
    {
        double resultAdd = Calculator.Add(15.5, 4.5);
        Console.WriteLine($"15.5 + 4.5 = {resultAdd}");

        double resultSubtract = Calculator.Subtract(20, 7);
        Console.WriteLine($"20 - 7 = {resultSubtract}");

        double resultMultiply = Calculator.Multiply(6, 3.5);
        Console.WriteLine($"6 * 3.5 = {resultMultiply}");

        double resultDivide = Calculator.Divide(100, 4);
        if (resultDivide == 0) {
            Console.WriteLine("Деление на ноль невозможно");
                }
        else
        {
            Console.WriteLine($"100 / 4 = {resultDivide}");
        }
        
    }
}