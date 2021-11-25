using System;
using System.IO;
using System.Collections.Generic;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionType<int> set1 = new CollectionType<int>(5);
            CollectionType<int> set2 = new CollectionType<int>(5);
            set1[0] = 1;
            set1[1] = 2;
            set1[2] = 2;
            set1[3] = 5;
            set1[4] = 7;

            set2[0] = 1;
            set2[1] = 2;
            set2[2] = 2;
            set2[3] = 5;
            set2[4] = 7;
            set1.SaveAsFile();
            set2.SaveAsFile();
        }
        

        interface Imain<T> where T : struct
        {
            public void add(T index);// Добавить 
            public void del(T index);// Удалить
            public void show(T index);//показать
            public void iskl(T index);
        }

        class Owner
        {
            public string MyName;
            public string MyOrganization;
            public int id;
        }

        class CollectionType<T> : Imain<int>
        {
            private Owner Me = new Owner { MyName = "Maksimova Vera", MyOrganization = "BSTU", id = 8 };
            private Date MyDate = new Date { MyDate = (DateTime.Now).ToString() };
            private T[] set;
            private int size;
            public T this[int index]
            {
                get
                {
                    return set[index];
                }
                set
                {
                    set[index] = value;
                }
            }
            class Date
            {
                public string MyDate;
            }
            public CollectionType(int Size)
            {
                set = new T[Size];
                size = Size;
            }
            //начало перегразки операций
            //удаление элемента
            public static CollectionType<T> operator >>(CollectionType<T> set, int a)
            {

                CollectionType<T> delete_item = new CollectionType<T>(set.size);

                return delete_item;
            }
            //>  проверка на подмножество;
            public static bool operator >(CollectionType<T> set1, CollectionType<T> set2)
            {
                if (set1.Equals(set2))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public static bool operator <(CollectionType<T> set1, CollectionType<T> set2)
            {
                return true;
            }
            //!=  проверка множеств на неравенство

            public static bool operator !=(CollectionType<T> set1, CollectionType<T> set2)
            {
                if (set1.Equals(set2))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public static bool operator ==(CollectionType<T> set, CollectionType<T> set2)
            {
                return true;

            }
            //+ добавить элемент в множество 
            public static CollectionType<T> operator +(CollectionType<T> set, T a)
            {

                CollectionType<T> add = new CollectionType<T>(set.size);
                add = set;
                return add;
            }



            public static CollectionType<T> operator <<(CollectionType<T> set, int a)
            {

                CollectionType<T> add = new CollectionType<T>(set.size);
                add = set;
                //add.Add(a);

                return add;
            }


            //% пересечение множеств.
            public static bool operator %(CollectionType<T> set, CollectionType<T> set2)
            {
                if (set.Equals(set2))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            // конец перегрузки операций 
            public void del(int index)
            {
                for (int i = index, j = i + 1; i < size - 1; i++, j = i + 1)
                    this[i] = this[j];
                size--;
            }

            public void iskl(int index)
            {
                try
                {
                    int x = 5;
                    int y = x / 0;
                    Console.WriteLine($"Результат: {y}");
                }
                catch
                {
                    Console.WriteLine("Возникло исключение!");
                }
                finally
                {
                    Console.WriteLine("Блок finally");
                }
            }
            public void add(int index)
            {
                return;
            }
            public void show(int index)
            {
                return;
            }
            public void SaveAsFile()
            {
                string TEXT = $"Владелец: {Me.MyName}\nID владельца: {Me.id}\nОрганизация: {Me.MyOrganization}\nМножество: ";
                foreach (T i in set)
                    TEXT += i + " ";
                TEXT += "\t                    \t";
                File.AppendAllText("D:\\2 курс\\ООП\\С#\\8 лабараторная\\laba8.json", TEXT);
            }

            //товар 5 лабараторная
            class Tovar
            {
                public int kolvo { get; set; }
                public string NameOfTovar { get; set; }
            }
            class TovarControl<T> where T : Tovar
            {
                public virtual void show()
                {
                    Console.WriteLine("Товар ");
                }
                public void input_kolvo(T Tovar)
                {
                    Tovar.kolvo = Convert.ToInt32(Console.ReadLine());
                }
                public void input_NAmeOfTovar(T Tovar)
                {
                    Tovar.NameOfTovar = Console.ReadLine();
                }

                public override string ToString()
                {
                    return "Использован метод ToString()";
                }
            }
        }
    }
}