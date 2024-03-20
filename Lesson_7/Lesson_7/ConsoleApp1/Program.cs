using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Zapros
    {
        private Sklad sklad1 = new Sklad();                                     //Композиция
        public string IDZakaz = "dfg-34";
        public void Zakaz()
        {
            Console.WriteLine("поступил заказ на товар" + IDZakaz);
        }
        Tovar[] Sklad = { new Prodovol(), new NeProdovol()};
        public void ZaprosNaSklad()
        {
            foreach (var sklad in Sklad)
            {
                sklad1.OTovare(sklad);
            }
        }
    }
    class Sklad 
    {
        public void ZapolnenieSklada()
        {
            
        }
        public void OTovare(Tovar tovar)
        {
            tovar.Tovari();
        }

    }

    abstract class Tovar                                                                    // Абстраутный клас
    {
       
       abstract public void Tovari();                                                       // абстрактный метод
        abstract public void basa();

    }
    class Prodovol : Tovar
    {
        public int kolvo;
        public string Naimenovanie;
        public string IDTovara;
        public DateTime date;  
        public string Srokgodnosti;
        public override void Tovari()                                                       // реализация контракта
        {
            Console.WriteLine("& Срок годности товара истекает {0}, а сегодня {1}", Srokgodnosti, date);
            Console.WriteLine("$ В наличие: \t {0} \t {1} \t ID товара: \t{3}", kolvo, Naimenovanie, IDTovara);
        }
        public override void basa()
        {
            Console.WriteLine("введите наименование товара");
            Naimenovanie = Console.ReadLine();
            Console.WriteLine("введите ID товара");
            IDTovara = Console.ReadLine();
            Console.WriteLine("введите количество товара");
            kolvo = int.Parse(Console.ReadLine());
            Console.WriteLine("введите срок годности товара");
            Srokgodnosti = Console.ReadLine();
        }
    }
    class NeProdovol : Tovar
    {
        public int kolvo ;
        public string Naimenovanie ;
        public string IDTovara ;
        public override void Tovari()                                                       // реализация контракта
        {
            Console.WriteLine("Срок годности товара отсутствует");
            Console.WriteLine("$ В наличие: \t {0} \t {1} \t ID товара: \t{3}", kolvo, Naimenovanie, IDTovara);
        }
        public override void basa()
        {
            Console.WriteLine("введите наименование товара");
            Naimenovanie = Console.ReadLine();
            Console.WriteLine("введите ID товара");
            IDTovara = Console.ReadLine();
            Console.WriteLine("введите количество товара");
            kolvo = int.Parse(Console.ReadLine());
            
        }
    class sotrudnik:dostavka
    {
        public string Name;
        enum dolzhnost
        {
            Доставщик =1, 
            Выдавальщик,
            Директор
        }
    }
    class dostavka
    {
        public string adress_dostavki;
        public enum punktVidachi
        {
            На_волгоградской =1,
            На_московской,
            На_свердловской
            
        }

        public virtual void kemDostavka() 
        {
            Console.WriteLine(" подготовка товара к отправке");
        }
    }

    class dostavkaDoDoma: dostavka
    {
        public override void kemDostavka()
        {
            Console.WriteLine("Доставка будет осуществлена курьером по адресу {0}", adress_dostavki);
        }
    }
    class dostavkaVPunkt : dostavka
    {
        public override void kemDostavka()
        {
            Console.WriteLine("Доставка будет осуществлена до пункта выдачи {0}", punktVidachi.На_свердловской);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}
