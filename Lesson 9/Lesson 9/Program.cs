using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson_9.Program;

namespace Lesson_9
{
    public class Program
    {

        static void Main(string[] args)
        {

            List<Sotrudnik> sp = new List<Sotrudnik>()
            {
               new Sotrudnik(){Name="Иван"},
               new Sotrudnik(){Name="Михаил"},
               new Sotrudnik(){Name="Егор"},
               new Sotrudnik(){Name="Андрей"},
               new Sotrudnik(){Name="Николай"}
            };

            Vibor vibors= new Vibor();
            vibors.Numberentr += Vivod;
            while (true)
            {
                try
                {
                    vibors.Read(sp);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine(" введено не число ");
                }
                catch (Exception)
                {
                    Console.WriteLine(" введено некорректное число");
                }
            }

            Console.ReadKey();

        }



        public static void Vivod(int vn, List<Sotrudnik> listSotrudnik)
        {
            switch (vn)
            {
                case 1: SortByAscending(listSotrudnik); break;
                case 2: SortByDecending(listSotrudnik); break;
            }
        }

        public class Sotrudnik
        {
            public string Name;
        }
        public static void SortByAscending(List<Sotrudnik> listSotrudnik)
        {
            var sortPeople = from p in listSotrudnik orderby p.Name ascending select p;
            foreach (var p in sortPeople)
            {
                Console.WriteLine(p.Name);
            }
        }
        public static void SortByDecending(List<Sotrudnik> listSotrudnik)
        {
            var sortPeople = from p in listSotrudnik orderby p.Name descending select p;
            foreach (var p in sortPeople)
            {
                Console.WriteLine(p.Name);
            }
        }
        class Vibor
        {
            public delegate void NamberEntereddeligate(int number, List<Sotrudnik> listSotrudnik);
            public event NamberEntereddeligate Numberentr;
            public void Read(List<Sotrudnik> listSotrudnik)
            {
                Console.WriteLine();
                Console.WriteLine("Как вы хотите вывести список сотрудников:");
                Console.WriteLine("введите 1 если от А до Я");
                Console.WriteLine("введите 2 если от Я до А");

                int vibor = Convert.ToInt32(Console.ReadLine());
                if (vibor != 1 && vibor != 2) throw new Exception();

                NamberEntered(vibor,  listSotrudnik);
            }
            protected virtual void NamberEntered(int vibor, List<Sotrudnik> listSotrudnik)
            {
                Numberentr?.Invoke(vibor, listSotrudnik);
                
            }
        }
    }
}
 
