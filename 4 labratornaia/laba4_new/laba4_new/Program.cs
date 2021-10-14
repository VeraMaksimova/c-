using System;
using System.Collections.Generic; // подключаем HashSet<T>
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace laba4_new
{   /*
     
    Методы расширения:
    1) Поиск самого короткого слова
    */
    

    public class Owner
    {
        public string name;
        public string organization;
        public uint id;
    }
    public class MySet<T> : HashSet<T> 
    {   
        private Owner person = new Owner { name = "Vera", organization = "BSTU", id = 8 };
        //private Date date = new Date { date = (DateTime.Now).ToString() };
        //>> удалить элемент из множества 
        private T[] array;
        private uint size;
        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        //удаление элемента
        public static MySet<T> operator >>(MySet<T> set, int a )
        {
            
            MySet<T> delete_item =new  MySet<T>();
            
            return delete_item;
        }
        //>  проверка на подмножество;
        public static bool operator >(MySet<T> set, MySet<T> set2)
        {
            if (set.Equals(set2)) {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static bool operator <(MySet<T> set, MySet<T> set2)
        {
            return true;
        }
        //!=  проверка множеств на неравенство

        public static bool operator !=(MySet<T> set, MySet<T> set2)
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
        public static bool operator ==(MySet<T> set, MySet<T> set2)
        {
            return true;

        }
        //+ добавить элемент в множество 
        //public static MySet<T> operator +(MySet<T> set ,T a)
        //{

        //    MySet<T> add = new MySet<T>();
        //    add = set;
        //    add.Add(a);

        //    return add;
        //}



        public static MySet<T> operator <<(MySet<T> set, int a)
        {

            MySet<T> add = new MySet<T>();
            add = set;
            //add.Add(a);

            return add;
        }


        //% пересечение множеств.
        public static bool operator %(MySet<T> set, MySet<T> set2)
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
 


        }
    public static class StaticOperation
    {      
        //1)Поиск самого короткого слова

        public static string long_word(this MySet<string> set)
        {
            string str = "";
            for(int i = 0; i < set.Count; i++)
            {
                if(set[i].Length > str.Length)
                {
                    str = set[i];
                }
            }

            return str;
        }
        //2) Упорядочивание множества
        public static MySet<string> set_U(this MySet<string> set)
        {

            string str ="";
            
            for (int i = 0; i < set.Count; i++)
            {
                if (set[i].Length < str.Length)
                {
                    str = set[i - 1];
                }
            }
            return set;
        }
       
      
    }



    class Program
    {
        static void Main(string[] args)
        {
            
            MySet<string> SET2 = new MySet<string>() { "88", "kk", "ii", "iiii" };
            ///SET2 = SET2 + "new";
            MySet<string> SET1 = new MySet<string>() { "88", "kk", "ii", "iiii" };
            Console.WriteLine();
            foreach (var item in SET2)
            {
                Console.Write($"{item}\t");
            }

            SET2 = SET2 >> 1;

            foreach (var item in SET2)
            {
                Console.Write($"{item}\t");
            }
            bool t = SET2 % SET1;
            Console.Write($"{t}\t");
            SET1.long_word();
            SET1.set_U();
        }
    }
}
