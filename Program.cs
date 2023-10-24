using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
            static void Main(string[] args)
        {
            // Для цілочисельних значень
            Calculator<int> intCalculator = new Calculator<int>((a, b) => a + b, (a, b) => a - b, (a, b) => a * b, (a, b) => a / b);

            int result = intCalculator.PerformOperation(5, 3, intCalculator.Add);
            Console.WriteLine($"5 + 3 = {result}");

            result = intCalculator.PerformOperation(5, 3, intCalculator.Subtract);
            Console.WriteLine($"5 - 3 = {result}");

            result = intCalculator.PerformOperation(5, 3, intCalculator.Multiply);
            Console.WriteLine($"5 * 3 = {result}");

            result = intCalculator.PerformOperation(6, 3, intCalculator.Divide);
            Console.WriteLine($"6 / 3 = {result}");

            // Для дробових значень
            Calculator<double> doubleCalculator = new Calculator<double>((a, b) => a + b, (a, b) => a - b, (a, b) => a * b, (a, b) => a / b);

            double doubleResult = doubleCalculator.PerformOperation(5.5, 2.2, doubleCalculator.Add);
            Console.WriteLine($"5.5 + 2.2 = {doubleResult}");

            doubleResult = doubleCalculator.PerformOperation(5.5, 2.2, doubleCalculator.Subtract);
            Console.WriteLine($"5.5 - 2.2 = {doubleResult}");

            doubleResult = doubleCalculator.PerformOperation(5.5, 2.2, doubleCalculator.Multiply);
            Console.WriteLine($"5.5 * 2.2 = {doubleResult}");

            doubleResult = doubleCalculator.PerformOperation(6.6, 3.3, doubleCalculator.Divide);
            Console.WriteLine($"6.6 / 3.3 = {doubleResult}");
        }
    }
}

