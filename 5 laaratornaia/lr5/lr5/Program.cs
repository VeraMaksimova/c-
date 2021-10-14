using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Xml.Serialization;
/*Товар, Техника, Печатающее устройство, Сканер, Компьютер,
Планшет.
*/
namespace lr5
{
    class Program
    {
        static void Main(string[] args)
        {
            technic TOVAR = new technic();
            TOVAR.printSum_price(3, 5);
            TOVAR.printSum_price();
            Console.WriteLine(TOVAR.ToString());
            //
            List<lem> EL = new List<lem>();
            EL.Add(new aaa1());
            EL.Add(new bbb2());
            EL.Add(new ccc3());
            Printer printer = new Printer();
            foreach (lem E in EL)
            {
                printer.IAmPrinting(E);
                if (E is aaa1)
                    Console.WriteLine(" 111a");
                else if (E is bbb2)
                    Console.WriteLine("  222b");
                else if (E is ccc3)
                    Console.WriteLine("  333c");
            }
        }

        interface Icloneable
        {
            void show();
            void kolich();
            void input();
        }

        class Tovar : Icloneable
        {
            protected double price;
            public int sum;
            public virtual void show()
            {
                Console.Write("Товар");
            }
            public virtual void kolich()
            {
                Console.WriteLine("Введите количество");
                sum = Convert.ToInt32(Console.ReadLine());
            }

            public void input()
            {
                Console.WriteLine("Введите цену");
                price = Convert.ToInt32(Console.ReadLine());
            }
            public void printSum_price()
            {
                Console.WriteLine($"Размер: {price}");
                Console.WriteLine($"Размер: {sum}");
            }
            public override string ToString()
            {
                return "ToString()";
            }

        }
        sealed class technic : Tovar
        {
            public override void show()
            {
                base.show();
                Console.WriteLine("Техника");
            }
            public void printSum_price(int Sum, double Price)
            {
                Console.WriteLine($"количсетво : {Sum}");
                sum = Sum;
                Console.WriteLine($"количсетво : {Price}");
                price = Price;
            }
            public override string ToString()
            {
                return "ToString()";
            }
        }
        sealed class Pechat : Tovar
        {
            public override void show()
            {
                base.show();
                Console.WriteLine("Печатающее устройство");
            }
        }
        sealed class Scaner : Tovar
        {
            public override void show()
            {
                base.show();
                Console.WriteLine("Сканер");
            }
            public override string ToString()
            {
                return "ToString()";
            }
        }
        sealed class Kopm : Tovar
        {
            public override void show()
            {
                base.show();
                Console.WriteLine("Компьютер");
            }
            public override string ToString()
            {
                return "ToString()";
            }
        }

        sealed class planshet : Tovar
        {
            public override void show()
            {
                base.show();
                Console.WriteLine("Планшет");
            }
            public override string ToString()
            {
                return "ToString()";
            }
        }



        /// <summary>
        interface Ilem
        {
            void something();
        }
        abstract class lem
        {
            public abstract void something();
        }

        class aaa1 : lem, Ilem
        {
            private int som_num { get; set; }
            public override void something()
            {
                som_num = Convert.ToInt32(Console.ReadLine());
            }
        }

        class bbb2 : lem, Ilem
        {
            private bool isPressed { get; set; } = false;
            public override void something()
            {
                isPressed = Convert.ToBoolean(Console.ReadLine());
            }
        }

        class ccc3 : lem, Ilem
        {
            private int count { get; set; } = 0;
            public override void something()
            {
                Console.WriteLine("Кликните на кнопку");
                Console.ReadKey();
                count++;
            }
        }
        /// </summary>


        //7 з
        class Printer
        {
            public virtual void IAmPrinting(object someObj)
            {
                Console.Write(someObj.GetType());
            }
        }
    }
}
