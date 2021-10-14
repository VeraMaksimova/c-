using System;

namespace _3labara
{
    class Programm
    {
        partial class Abiturient
        {
            private string surname;
            private string name;
            private string patronomic;
            private string adress;
            private string phone_number;
            private int[] array_sucsess = new int[3];
            private int id { get; }
            static int N = 8;



            public int ID
            {
                get { return id; }
            }
            const double EXP = 2;
            //КОНСТРУКТОР С ПРОВЕРКОЙ ДАННЫХ
            public Abiturient(string SUR, string NAME, string PATRONOMIC, string ADRESS, string PHONE, int[] arr_)
            {
                surname = SUR;
                name = NAME;
                patronomic = PATRONOMIC;
                adress = ADRESS;
                phone_number = PHONE;




            }
            //Коснтруктор с двумя параметрами
            public Abiturient(string SUR, string NAME)
            {
                surname = SUR;
                name = NAME;
            }
            //Конструткор без параметров
            public Abiturient()
            {
                surname = "Иванов";
                name = "Иван";
            }
            //Статичсеский конструткор
            static Abiturient()
            {
                N = 6;
            }
            //Закрытый конструткор 
            private Abiturient(int n)
            {
                id = GetHashCode();
            }

            //Нужно
            public string GetSurname() { return surname; }
            public string GetName() { return name; }
            public string GetPatronomic() { return patronomic; }
            public string GetAdress() { return adress; }
            public string GetPhone() { return phone_number; }
            public int GetOts_0() { return array_sucsess[0]; }
            public int GetOts_1() { return array_sucsess[1]; }
            public int GetOts_2() { return array_sucsess[2]; }
            //ref
            public void Func(ref int value_1, out int value_2)
            {
                //val1 = 5;
                Console.WriteLine(value_1);
                value_2 = 10; // Обязательно
                Console.WriteLine(value_2);
            }


            //вывод
            static void information(Abiturient abitura)
            {
                Console.WriteLine($"{abitura.GetSurname()}\t{abitura.GetName()}\t{abitura.GetPatronomic()}\t{abitura.GetAdress()}\t{abitura.GetPhone()}\t{abitura.GetOts_0()}\t{abitura.GetOts_1()}\t{abitura.GetOts_2()}\t");
            }
            //методы
            //метод подсчета среднего балла
            public static void Sr_ball(Abiturient[] abiturients, int[] arr)
            {
                int summa = 0;
               for(int i = 0; i < 3; i++)
                {
                    summa = arr[i] + summa;

                }
                summa = summa / 3;
                Console.WriteLine(summa);


            }
            //Метод список абитуриетов сумма баллов выше заданной
            public static void find(Abiturient[] abiturients, int n, int[] arr, int[] arr1, int[] arr2)
            {
                for(int i = 0; i < 3; i++)
                {
                    if (arr[i] > n)
                    {
                         information(abiturients[0]);
                    }
                    if (arr1[i] > n)
                    {
                        information(abiturients[1]);
                    }
                    if (arr2[i] > n)
                    {
                        information(abiturients[2]);
                    }
                }
            }

            //Создание объектов
            static void Main(string[] args)
            {
                int[] arr_0 = new int[3];
                arr_0[0] = 4;
                arr_0[1] = 4;
                arr_0[2] = 4;

                int[] arr_1 = new int[3];
                arr_1[0] = 3;
                arr_1[1] = 2;
                arr_1[2] = 2;

                int[] arr_2 = new int[3];
                arr_2[0] = 5;
                arr_2[1] = 2;
                arr_2[2] = 5;


                Abiturient[] abiturients = new Abiturient[3];



                abiturients[0] = new Abiturient("Иванов", "Иван", "Петров", "г.Минск", "+375(29)666 44 33", arr_0);
                abiturients[1] = new Abiturient("Северянина", "Анастасия", "Кирилловна", "г.Витебск", "+375(29)777 55 33", arr_1);
                abiturients[2] = new Abiturient("Вишнева", "Ксения", "Владиславовна", "г.Бараовичи", "+375(29)235 43 55", arr_2);

                information(abiturients[0]);
                Sr_ball(abiturients, arr_0);
                information(abiturients[1]);
                Sr_ball(abiturients, arr_1);
                information(abiturients[2]);
                Sr_ball(abiturients, arr_2);
                

                Console.WriteLine("Введите число ");
                string k  = Convert.ToString( Console.ReadLine());

               int u = int.Parse(k);

                find(abiturients, u, arr_0, arr_1, arr_2);







            }
        }


    }
}

// вывод статических методов 
// var имя = new имя_класса {передача пар-ов}
//имя класса.метод(имя);