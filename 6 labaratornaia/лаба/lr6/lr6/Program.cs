using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Runtime.CompilerServices;
namespace lr6
{
    class Program
    {
        static void Main(string[] args)
        {
            labaratoria UserLabaratoria = new labaratoria();
            LBController lbController = new LBController();
            bool isWork = true;
            //количество срок цена имя
            UserLabaratoria.Add(new Pechat(), 23, 2, 44.3, "Печатающее устройство");
            UserLabaratoria.Add(new PC(), 8, 9, 33.3, "Пк");
            UserLabaratoria.Add(new Scaner(), 9, 10, 54.3, "Сканер");
            UserLabaratoria.Add(new Planshet(), 16, 4, 44.3, "Планшет");

            do
            {
                switch (UserLabaratoria.menu())
                {
                    case 1: lbController.PrintList(UserLabaratoria); break;
                    case 2: lbController.Printkolvoteh(UserLabaratoria); break;
                    case 3: lbController.spisok_teh(UserLabaratoria); break;
                    case 4: isWork = false; break;
                    default: Console.WriteLine("Некорректно введенные данные!"); break;
                }
            } while (isWork);
        }

    }

    enum EControlElements { Tovar, PC, planshet };
    struct Something
    {
        //string str;
        int d, f;
    }
    public interface Icontrol
    {
        void show();//Показать товар
        void input_p(); //Цена
        void size_k();// Количсетво товара 
        void SROK_();// Срок службы
    }
    public partial class Tovar : Icontrol
    {
        public int srok;
        public int kolvo;
        public double price;
        public string name;
        
        public virtual void show()
        {
            Console.Write(name );
        }
        public void  size_k()
        {
            Console.WriteLine("Введите количество: ");
            kolvo = Convert.ToInt32(Console.ReadLine());
        }
        public void input_p()
        {
            Console.WriteLine("Введите цену: ");
            price = Convert.ToDouble(Console.ReadLine());
        }
        public void SROK_()
        {
            Console.WriteLine("Введите срок службы: ");
            srok = Convert.ToInt32(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine($"Количество: {kolvo} Срок службы: {srok} Цена: {price}$ ");
        }

    }
    
    public sealed class Pechat : Tovar
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("Печатающее устрйоство");
        }
        public void print(int Kolvo, int Srok, double Price, string Name)
        {
            Console.WriteLine($"Количество: {kolvo} Срок службы: {srok} Цена: {price}$ Имя: {Name} ");
            kolvo = Kolvo;
            srok = Srok;
            price = Price;
            name = Name;
        }
    }

    public sealed class Scaner : Tovar
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("Сканер");
        }
        public void print(int Kolvo, int Srok, double Price , string Name)
        {
            Console.WriteLine($"Количество: {kolvo} Срок службы: {srok} Цена: {price}$ Имя: {Name} ");
            kolvo = Kolvo;
            srok = Srok;
            price = Price;
            name = Name;
        }
    }

    public sealed class PC : Tovar
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("PC");
        }
        public void print(int Kolvo, int Srok, double Price, string Name)
        {
            Console.WriteLine($"Количество: {kolvo} Срок службы: {srok} Цена: {price}$ Имя: {Name} ");
            kolvo = Kolvo;
            srok = Srok;
            price = Price;
            name = Name;
        }
    }
    public sealed class Planshet : Tovar
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("PC");
        }
        public void print(int Kolvo, int Srok, double Price, string Name)
        {
            Console.WriteLine($"Количество: {kolvo} Срок службы: {srok} Цена: {price}$ Имя: {Name} ");
            kolvo = Kolvo;
            srok = Srok;
            price = Price;
            name = Name;
        }
    }

    public partial class labaratoria
    {
        public List<object> Elements = new List<object>();
        public byte menu()
        {
            Console.Write($"1. Найти технику старше заданного срока службы\n" +
                          $"2. Подсчитать количество каждого вида техники\n" +
                          $"3. Вывести список техники в порядке убывания цены\n" +
                          $"4. exit\n" +
                          $"$ ");
            return Convert.ToByte(Console.ReadLine());
        }

    }

    public class LBController
    {   
        //Техника старше заданного срока службы
        // написать что выводим
        public void PrintList(labaratoria labaratoria)
        {
            Console.WriteLine("Введите искомый срок службы ");
            int s = Convert.ToInt32(Console.ReadLine());
            foreach (object obj in labaratoria.Elements)
            {
                try
                {
                    if(s < ((Tovar)obj).srok){

                        Console.WriteLine($"Название {((Tovar)obj).name}  Количество  {((Tovar)obj).kolvo} Срок  {((Tovar)obj).srok}  Цена {((Tovar)obj).price}$ ");
                    }
                }
                catch (System.InvalidCastException) { continue; }
            }
            
        }
        //Пересчитать количество каждого вида техники
        public void Printkolvoteh(labaratoria labaratoria)
        {
            int pc = 0;
            int pechat = 0;
            int scaner = 0;
            int planshet = 0;
            
            foreach (object obj in labaratoria.Elements)
            {
                
                try
                {
                    pc = ((PC)obj).kolvo + pc;
                }
                catch (System.InvalidCastException) { continue; }
            }
            foreach (object obj in labaratoria.Elements)
            {
                try
                {
                    pechat = ((Pechat)obj).kolvo + pechat;
                }
                catch (System.InvalidCastException) { continue; }
            }
            foreach (object obj in labaratoria.Elements)
            {
                try
                {
                    scaner = ((Scaner)obj).kolvo + scaner;
                }
                catch (System.InvalidCastException) { continue; }
            }
            foreach (object obj in labaratoria.Elements)
            {
                try
                {
                    planshet = ((Planshet)obj).kolvo + planshet;
                }
                catch (System.InvalidCastException) { continue; }
            }
            Console.WriteLine($"Количество пк: {pc}");
            Console.WriteLine($"Количество печающих устройств: {pechat}");
            Console.WriteLine($"Количество сканеров: {scaner}");
            Console.WriteLine($"Количество планшетов: {planshet}");
        }
        ///вывести список техники в порядке убывания цены
        public void spisok_teh(labaratoria labaratoria)
        {
            
            //------
            foreach (object obj in labaratoria.Elements)
            {
                double a = ((Tovar)obj).price;
                try
                {
                    foreach (object obj_ in labaratoria.Elements)
                    {
                        try
                        {
                            if(a > ((Tovar)obj_).price)
                            {
                                Console.WriteLine($"Название {((Tovar)obj).name}  Количество  {((Tovar)obj).kolvo} Срок  {((Tovar)obj).srok}  Цена {((Tovar)obj).price}$ ");
                            }
                        }
                        catch (System.InvalidCastException) { continue; }

                    }


                }
                catch (System.InvalidCastException) { continue; }
            }
           
        }
    }


}
