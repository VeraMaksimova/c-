using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-ое задание 
            //Вывести строку получить из строки первое слово

            string str = "привет как дела";
            str = str.Substring(0, str.IndexOf('к'));
            Console.WriteLine(str);
            char[,,] myArr = new char[2, 2, 2] { { {'1','2' }, { '3', '4'} }, { { '5', '6' }, { '7', '8' } } };
            //полследовательность цифрами



            Mammal mammal1 = new Mammal { Name = "Angela", Birthday ="2021", Type = "2001"};
            Mammal mammal2 = new Mammal { Name = "Karin", Birthday = "2021", Type = "2001" };
            bool BOO = mammal1.Equals(mammal2);
            Console.WriteLine(BOO);
            //Массив объектов
            House[] houses = new House[3];
            for (int i = 0; i <3; i++)
            {
                houses[i] = new House();
            }
            houses[0].Name = "jjj";
            houses[0].Birthday = "2020";
            houses[0].Type = "30";
            houses[0].color = "Yellow";

            houses[1].Name = "jjj";
            houses[1].Birthday = "2020";
            houses[1].Type = "30";
            houses[1].color = "Yellow";

            houses[1].Name = "jjj";
            houses[1].Birthday = "2020";
            houses[1].Type = "30";
            houses[1].color = "Green";

            


            try
            {
                houses[0].Age();
                houses[1].Age();
                houses[2].Age();
                string AGEEE = mammal1.Age();
                int a = Convert.ToInt32(AGEEE);
                if(a < 1)
                {
                    throw new Exception("NotImplemendedYet");
                }
                else
                {
                    Console.WriteLine("Всё классно");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

        }
        interface IAgeable
        {
            string Age();
        }

        class Mammal : IAgeable
        {
            public string Name { get; set; }
            public string Birthday { get; set; }
            public string Type { get; set; }
            

            public override bool Equals(object obj)
            {
                if (obj.GetType() != this.GetType()) return false;

                Mammal time = (Mammal)obj;
                return ((this.Birthday == time.Type));
            }
            public string Age()
            {
                int HELP = 2021;
                int HELP2 = Convert.ToInt32(Birthday);
                int Age = HELP - HELP2;
                string AGE = Convert.ToString(Age);
                Console.WriteLine(AGE);
                return AGE;
                
            }

        }
        class House : Mammal
        {
            public string color { get; set; }
            public string Age()
            {
                int HELP = 2021;
                int HELP2 = Convert.ToInt32(Birthday);
                int Age = HELP - HELP2;
                string AGE = Convert.ToString(Age);
                Console.WriteLine(AGE);
                return AGE;

            }
        }
        
    }
}
