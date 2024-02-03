using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Как я могу к тебе обращаться?");
            string MyName = Console.ReadLine();
            Console.WriteLine(" Сколько тебе лет?");
            int MyAge = int.Parse(Console.ReadLine());
            Console.WriteLine(" а когда ты родился?");
            string birthday = Console.ReadLine();
            Console.WriteLine(" в каком городе сейчас проживаешь?");
            string city = Console.ReadLine();

            Console.WriteLine("Приятно познакомиться {0}, из {1}, родившийся {2} и достигший {3} полных лет", MyName, city, birthday, MyAge);
            Console.ReadKey();
        }
    }
}
