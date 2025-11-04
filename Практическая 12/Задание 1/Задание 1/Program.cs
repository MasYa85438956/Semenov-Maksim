using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{

        public static class Calculator
        {
            public static double Add(double a, double b)
            {
                return a + b;
            }

            public static double Subtract(double a, double b)
            {
                return a - b;
            }

            public static double Multiply(double a, double b)
            {
                return a * b;
            }

            public static double Divide(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно.");
                    return 0; 
                }
                return a / b;
            }
        }
        class Program
        {
            static void Main()
            {
                double sum = Calculator.Add(5, 3);
                double difference = Calculator.Subtract(10, 4);
                double product = Calculator.Multiply(6, 7);
                double quotient = Calculator.Divide(8, 0);

                Console.WriteLine($"Сумма: {sum}");
                Console.WriteLine($"Разность: {difference}");
                Console.WriteLine($"Произведение: {product}");
                Console.WriteLine($"Частное: {quotient}");
            Console.ReadKey();
            }
        }
    }

