using System;
using System.Buffers;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace var6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*А вывести максимально допустимое число типа ushort
             Cоздать массив String заолнить днями недели
            */

            //ushort max = 65535;//2 байта
            //Console.WriteLine(Convert.ToString(max));

            //string[] Week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };


            /*Создать класс Card c number, month, year, balance.
             Сделать для них свойства, 
            Одно с проверкой корректности
            Одно автоматичское 
            Одно для чтения 
            Переопределить оператор + и - 
            Для пополнения и снятия  суммы баланса 
            напишшите демонстрацию*/

            Card card1 = new Card { year = 2001, balance = 344};
            int historybalance = card1.balance;
            card1.month = 3;
            card1.Print();
            card1 = card1 - 200;
            card1.Print();
            card1 = card1 + 300;
            card1.Print();
            Console.WriteLine(Convert.ToString(card1.Check()));
            CardWithHistory history = new CardWithHistory();
            if (historybalance > card1.balance)
            {
                history.a[1] = "С карты было снято " + (historybalance - card1.balance);
            }
            else
            {
                history.a[1] = "На карту было добавлено " + (card1.balance - historybalance);
            }
            
            /*Создать интрфейс Icheck
            c методом bool Check()
            Реализовать интрфейс для класса Card, 
            проверяет положителен ли баланс.
            Создать класс CardWithHistory наследуется от Card и
            содержит массив строк с историей операций по карте*/
            

        }
        interface Icheck {
            bool Check();
        }



        class Card
        {
            public readonly string number = "0000 1111 2222 3333";//только для чтения
            int Month;
            public int year { get; set; }// автоматичсекое
            int countMax = 0;
            int countMin = 0;
            public int month
            {

                set
                {
                    if (value < 1 || value > 12)
                        Console.WriteLine("Месяц некорректный");
                    else
                        Month = value;
                }
                get { return Month; }


            }

            public int balance { get; set; }

            public static Card  operator +(Card card, int sum)
            {
                return new Card { balance = card.balance + sum};
            }
            int i = 0;
            public static Card operator -(Card card, int sum)
            {
                return new Card { balance = card.balance - sum };

            }
            public void Print()
            {
                Console.WriteLine($"\nБаланс на карте: {balance}$\nНомер карты: {number}");
            }
            public bool Check()
            {
                if (balance > 0) {
                    return true; 
                }
                else
                {
                    return true;
                }
            }
            
        }
        //Создать класс CardWithHistory наследуется от Card и
        //    содержит массив строк с историей операций по карте*/
        class CardWithHistory : Card
        {
            public string[] a = new string[20];
            
            


        }
    }
}
