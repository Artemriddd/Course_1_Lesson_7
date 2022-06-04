using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_1_Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Сегодня жарко?");
            string str = Console.ReadLine();
            if (str == "Да")
            {
                Console.WriteLine("Мне тоже!");
            }
            else
            {
                Console.WriteLine("Ну и ладно...");
            }
            Console.ReadKey(true);
        }
    }
}
