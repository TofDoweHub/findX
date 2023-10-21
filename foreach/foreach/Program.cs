using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите операцию:");
                char operation = Convert.ToChar(Console.ReadLine());
                Console.Write("Введите известное число:");
                double knownNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите результат:");
                double result = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(findX(operation, knownNumber, result));

                Console.ReadKey();
            }
        }
        static double findX(char operation, double knownNumber, double result)
        {
            switch(operation)
            {
                case '/':
                    return result * knownNumber;
                case '+':
                    return result - knownNumber;
                case '-':
                    return result + knownNumber;
                case '*':
                    return result / knownNumber;
                default:
                    Console.WriteLine("Что-то пошло не так... Убедитесь, что не ошиблись при написании!");
                    return 0;
            }
        }
    }
}
