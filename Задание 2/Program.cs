using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    /// <summary>
    /// Задача 2. Найти минимальную величину их трех целых переменных a, b, c 
    /// с использованием вспомогательных методов (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    internal class Program
    {
        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Minimum(int x, int y, int z)
        {
            int temp = x < y ? x : y;
            return temp < z ? temp : z; 

        }

        static void Main(string[] args)
        {
            int x = Input("Введите x = ");
            int y = Input("Введите y = ");
            int z = Input("Введите z = ");
            int min = Minimum(x, y, z);
            Console.WriteLine($"Мнимальное значение: {min}");

            Console.ReadLine();
        }
    }
}
