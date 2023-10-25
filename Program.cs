using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
            static void Task1()
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
        
            static void Task2()
        {
            // Створюємо репозиторій для рядків
            Repository<string> stringRepository = new Repository<string>();

            // Додаємо рядки до репозиторію
            stringRepository.Add("apple");
            stringRepository.Add("banana");
            stringRepository.Add("cherry");
            stringRepository.Add("date");

            // Створюємо критерій для пошуку
            Criteria<string> criteria = s => s.Length == 5; // Знайти рядки з довжиною 5 символів

            // Виконуємо пошук
            List<string> result = stringRepository.Find(criteria);

            // Виводимо результат
            Console.WriteLine("Результат пошуку:");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

            private static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();

            // delay to read from screen
            Console.WriteLine("Press any key to finnish this program...");
            Console.Read();
        }
    }
}


