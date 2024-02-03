

Console.WriteLine("Привет! Как я могу к тебе обращаться?");
string MyName =  Console.ReadLine();
Console.WriteLine(" Сколько тебе лет?");
int MyAge = int.Parse(Console.ReadLine());
Console.WriteLine(" а когда ты родился?");
string birthday = Console.ReadLine();
Console.WriteLine(" в каком городе сейчас проживаешь?");
string city = Console.ReadLine();

Console.WriteLine("Приятнол познакомиться {0}, из {1}, родившийся {2} и достигший {3} полных лет", MyName, city, birthday, MyAge);
Console.ReadKey();