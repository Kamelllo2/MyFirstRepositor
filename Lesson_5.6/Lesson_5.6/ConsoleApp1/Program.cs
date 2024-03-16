using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstuser = GetUser();
            firstuser.Print();
            Console.ReadKey();

        }
        class User
        {
            public string Name;
            public string lastName;
            public byte age;
            public bool animal;
            public int animalCount;
            public string[] animalName;
            public string[] colorOFlove;

            public void Print()
            {
                Console.WriteLine("Имя " + Name);
                Console.WriteLine("Фамилия " + lastName);
                Console.WriteLine("Возраст " + age);
                if (animal == true)
                {
                    Console.WriteLine("Имеет " + animalCount + " животных");
                    for (int i = 0; i < animalCount; i++)
                    {
                        Console.WriteLine("Имя " + (i + 1) + " животного: " + animalName[i] + "\n");
                    }

                }
                else
                {
                    Console.WriteLine("Животных не имеет");
                }
                Console.WriteLine("любимые цвета: ");
                for (int i = 0; i < colorOFlove.Length; i++)
                {
                    Console.WriteLine(colorOFlove[i]);
                }

            }


        }
        static User GetUser()
        {
            var User = new User();

            Console.WriteLine("Введите имя пользователя?");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию пользователя?");
            User.lastName = Console.ReadLine();
            User.age = 0;
            while (User.age <= 0)
            {
                Console.WriteLine("Введите возраст пользователя?");
                try
                {
                    User.age = byte.Parse(Console.ReadLine());
                    if (User.age <= 0 || User.age > 150)
                    {
                        Console.WriteLine("ввели некоректное число");
                        User.age = 0;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено не число");
                    User.age = 0;
                }
            }

            string animalvalid = "неизвестно";
            while (animalvalid == "неизвестно")
            {
                Console.WriteLine("У пользователя есть животные? да/нет");

                animalvalid = Console.ReadLine();
                if (animalvalid == "Да" || animalvalid == "да" || animalvalid == "yes")
                {
                    User.animal = true;
                    continue;
                }
                if (animalvalid == "Нет" || animalvalid == "нет" || animalvalid == "no")
                {
                    User.animal = false;
                    continue;
                }
                else
                {
                    Console.WriteLine("только да/нет");
                    animalvalid = "неизвестно";
                }
            }
            if (User.animal == true)
            {
                User.animalCount = 0;
                while (User.animalCount == 0)
                {
                    Console.WriteLine("сколько животных у пользователя?");
                    try
                    {
                        User.animalCount = int.Parse(Console.ReadLine());
                        if (User.animalCount <= 0)
                        {
                            Console.WriteLine("слишком мало животных при условии что они есть XD");
                            User.animalCount = 0;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введено не число");
                        User.animalCount = 0;
                    }


                }
                User.animalName = new string[User.animalCount];
                for (int i = 0; i < User.animalCount; i++)
                {
                    Console.WriteLine("введите имя " + (i + 1) + " животного");
                    User.animalName[i] = Console.ReadLine();
                }


            }

            byte colorCount = 0;
            while (colorCount == 0)
            {
                Console.WriteLine("сколько любимых цветов у пользователя?");
                try
                {
                    colorCount = byte.Parse(Console.ReadLine());
                    if (colorCount > 4)
                    {
                        Console.WriteLine("многовато любимых цветов, давай поменьше");
                    }
                    if (colorCount <= 0)
                    {
                        Console.WriteLine("маловато будет");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено не число");
                }
            }
            User.colorOFlove = new string[colorCount];
            for (int i = 0; i < colorCount; i++)
            {
                Console.WriteLine("введите название " + (i + 1) + " любимого цвета");
                User.colorOFlove[i] = Console.ReadLine();

            }

            return User;





        }
    }
}
