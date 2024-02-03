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
            int MyAge = 0;
            Console.WriteLine("Привет! Как я могу к тебе обращаться?");
            string MyName = Console.ReadLine();            
           while (MyAge == 0)
            {
                Console.WriteLine(" Сколько тебе лет?");
                bool MyAgeValid = int.TryParse(Console.ReadLine(), out (MyAge));
                if (MyAgeValid != true)
                {
                    Console.WriteLine("вы ввели не число");
                }
                if (MyAgeValid == true & MyAge<0 )
                {
                    Console.WriteLine("вы ввели отрицательное число");
                    MyAge = 0;
                }
            }
            
            Console.WriteLine(" а когда ты родился?");
            string birthday = Console.ReadLine();
            Console.WriteLine(" в каком городе сейчас проживаешь?");
            string city = Console.ReadLine();

            Console.WriteLine("Приятно познакомиться {0}, из {1}, родившийся {2} и достигший {3} полных лет", MyName, city, birthday, MyAge);
            Console.ReadKey();
        }
    }
}
