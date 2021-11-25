using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // А вывести сумму максимально допустимого числа Uint и минимального типа int
            int min = -2147483648;
            uint max = 4294967295;
            long sum = min + max;
            Console.WriteLine(Convert.ToString(sum));//т.к uint 4 байта но от 0,
            //а int 4 байта но в обе целочисленные стороны


            // А Создать и проиницилизировать дмерный массив строк  и вывести его на консоль 
            string[,] array_str = new string[2, 2] { { "hello", "me" }, { "GOOD", "help" } };
            foreach (string j in array_str)
            {
                Console.WriteLine($"{j}");
            }

            /*Создать partial class Time c hour, minute, second.
             В одной части определить свойства с проверкой корректности. 
            в Другой переопделить метод Equals - сравнивает по всем полям.
            Переопределите операцию == сравните только по часам. Создать два объекта и сранвите их*/



            Time time = new Time { hour = 20, minute = 34, second = 53 };
            Time time1 = new Time { hour = 10, minute = 55, second = 1 };
            bool eq = (time == time1);
            Console.WriteLine(Convert.ToString(eq));


            /*Создать интрфейс Ipossible c методом check().
            Реализвать в классе Time интерфейс Iposiible (проверяет день ночь)
            и стандартный интрфейс IComparable.
            Создать массив из 5 объектов Time. 
            Генерировать пользовательское исключание, если в массиве больше ночного времени, чем дневного.
            Обработайте исключение*/
            time.check();
            time1.check();
            

            Time[] times = new Time[5];
            for (int i = 0; i < 5; i++)
            {
                times[i] = new Time();
            }
            times[0].hour = 23;
            times[0].minute = 50;
            times[0].second = 30;
            //
            times[1].hour = 0;
            times[1].minute = 20;
            times[1].second = 33;
            //
            times[2].hour = 4;
            times[2].minute = 30;
            times[2].second = 50;
            //
            times[3].hour = 0;
            times[3].minute = 32;
            times[3].second = 22;
            //
            times[4].hour = 22;
            times[4].minute = 3;
            times[4].second = 2;

            
            
            try
            {
                int ch = 0;
                for (int i = 0; i < times.Length; i++)
                {
                    string str = Convert.ToString(times[0].check());
                    if(str == "Сейчас ночь")
                    {
                        ch = ch + 1;
                    }
                }
                if(ch > 2)
                {
                    throw new Exception("В массиве всё время ночь");
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

            foreach (Time t in times)
            {
                Console.WriteLine("Часы Минуты Секунды");
                Console.WriteLine($"{t.hour}  -  {t.minute}  -  {t.second}");
            }



        } 

        interface Ipossible
        {
            string check();
        }

        public interface IComparable
        {
            int CompareTo(object o);
        }

        partial class Time : Ipossible, IComparable
        {    //Реаоизация интерфейса 
         
            public int hour { get; set; }
            public int minute { get; set; }
            public int second { get; set; }
            public string check()
            {
                if ((hour < 5) || (hour > 18))
                {
                    return "Сейчас ночь";
                }
                else
                {
                    return "Сейчас день";
                }
            }
            public int CompareTo(object o)
            {
                Time p = o as Time;
                if (p != null)
                    return this.hour.CompareTo(p.hour);
                else
                    throw new Exception("Невозможно сравнить два объекта");
            }

            //EQUELS
            public override bool Equals(object obj)
            {
                if (obj.GetType() != this.GetType()) return false;

                Time time = (Time)obj;
                return ((this.hour == time.hour) && (this.minute == time.minute) && (this.second == time.second));
            }

            public static bool operator ==(Time time, Time time2) {
                if (time.hour == time2.hour)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //
            public static bool operator !=(Time time, Time time2) {
                return false;
            }
           
            

           

        }
    }
}
