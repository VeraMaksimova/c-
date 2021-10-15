using System;
/*Создать Лабораторию и наполнить ее техникой.
Найти технику старше заданного срока службы. Подсчитать
количество каждого вида техники. Вывести список техники
в порядке убывания цены.*/
namespace lr6
{
    partial class labaratoria
    {
        public void Add(Pechat Tovar, int Kolvo, int Srok, double Price, string Name)
        {
            Tovar.kolvo = Kolvo;
            Tovar.srok = Srok;
            Tovar.price = Price;
            Tovar.name = Name;

            Elements.Add(Tovar);
        }
        public void Add(PC Tovar, int Kolvo, int Srok, double Price, string Name)
        {
            Tovar.kolvo = Kolvo;
            Tovar.srok = Srok;
            Tovar.price = Price;
            Tovar.name = Name;

            Elements.Add(Tovar);
        }
        public void Add(Scaner Tovar, int Kolvo, int Srok, double Price, string Name)
        {
            Tovar.kolvo = Kolvo;
            Tovar.srok = Srok;
            Tovar.price = Price;
            Tovar.name = Name;

            Elements.Add(Tovar);
        }
        public void Add(Planshet Tovar, int Kolvo, int Srok, double Price, string Name)
        {
            Tovar.kolvo = Kolvo;
            Tovar.srok = Srok;
            Tovar.price = Price;
            Tovar.name = Name;

            Elements.Add(Tovar);
        }
        ///------------------------
        public object this[int index]
        {
            get
            {
                return Elements[index];
            }
        }
        public void Delete(int index)
        {
            Elements.Remove(index);
        }
        public void Print()
        {
            foreach (object obj in Elements)
                Console.WriteLine(obj);
        }
    }
}
