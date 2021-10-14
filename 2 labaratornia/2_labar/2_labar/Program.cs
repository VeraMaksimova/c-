using System;
using System.Text;

//namespace _2_labar//Пространство имен 
//{
//    class Program// класс
//    {
//static void Main(string[] args)//Метод класса
//                               //ТИПЫ nint, nuint ЗАБЫЛи
//{   /*Определите переменные всех возможных примитивных типов 
//    С# и проинициализируйте их. Осуществите ввод и вывод их 
//    значений используя консоль*/
//    Console.WriteLine("Проинициализируйте переменную bool\n");
//    bool Bool_1 = Convert.ToBoolean(Console.ReadLine());//хранит значение true или false (логические литералы). Представлен системным типом System.Boolean
//    Console.WriteLine("Проинициализируйте переменную byte\n");
//    byte Byte_1 = Convert.ToByte(Console.ReadLine());//хранит целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte
//    Console.WriteLine("Проиницилизируйте  переменную sbyte\n");
//    sbyte Sbyte_1 = Convert.ToSByte(Console.ReadLine());//sbyte: хранит целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte
//    Console.WriteLine("Проинициализируйте переменную short\n");
//    short Short_1 = Convert.ToInt16(Console.ReadLine());//short: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16
//    Console.WriteLine("Проинициализируйте переменную ushort\n");
//    ushort Ushort_1 = Convert.ToUInt16(Console.ReadLine());//ushort: хранит целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16
//    Console.WriteLine("Проинициализируйте переменную int\n");
//    int Int_1 = Convert.ToInt32(Console.ReadLine());//int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32. Все целочисленные литералы по умолчанию представляют значения типа int
//    Console.WriteLine("Проинициализируйте переменную uint\n");
//    uint Uint_1 = Convert.ToUInt32(Console.ReadLine());//uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32
//    Console.WriteLine("Проиницилизирйте переменную long\n");
//    long Long_1 = Convert.ToInt64(Console.ReadLine());//long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт. Представлен системным типом System.Int64
//    Console.WriteLine("Проинициализируйте переменную ulong\n");
//    ulong Ulong_1 = Convert.ToUInt64(Console.ReadLine()); //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт. Представлен системным типом System.UInt64
//    Console.WriteLine("Проиницилизируйте переменную float\n");
//    float Float_1 = Convert.ToSingle(Console.ReadLine());//float: хранит число с плавающей точкой от -3.4*10^38 до 3.4*10^38 и занимает 4 байта. Представлен системным типом System.Single
//    Console.WriteLine("Проинициализируйте переменную double\n");
//    double Double_1 = Convert.ToDouble(Console.ReadLine());//double: хранит число с плавающей точкой от ±5.0*10^-324 до ±1.7*10^308 и занимает 8 байта. Представлен системным типом System.Double
//    Console.WriteLine("Проинциализируйте переменную decimal\n");
//    decimal Decimal_1 = Convert.ToDecimal(Console.ReadLine());//decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт. Представлен системным типом System.Decimal
//    Console.WriteLine("Проинициализируйте переменную char\n");
//    char Char_1 = Convert.ToChar(Console.ReadLine());//char: хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char. Этому типу соответствуют символьные литералы:
//    Console.WriteLine("Проинциализируйте переменную string\n");
//    string String_1 = Console.ReadLine();//string: хранит набор символов Unicode. Представлен системным типом System.String. Этому типу соответствуют строковые литералы.
//    Console.WriteLine("Проинициализируйте переменную object\n");
//    object Object_1 = Console.ReadLine();//object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе. Представлен системным типом System.Object, который является базовым для всех других типов и классов .NET.
//    Console.WriteLine("Проинициализируйте переменную dynamic\n");
//    dynamic Dynamic_1 = Console.ReadLine();
//    /**Для вывода данных на консоль здесь применяется интерполяция: перед строкой ставится знак $
//     и после этого мы можем вводить в строку в фигурных скобках значения переменных. Консольный вывод программы:*/
//    Console.WriteLine($"bool: {Bool_1} \n byte: {Byte_1}\n sbyte: {Sbyte_1}\n short: {Short_1}\n ushort: {Ushort_1}\n int: {Int_1}\n uint:{Uint_1}\n long: {Long_1}\n ulong: {Ulong_1}\n float{Float_1}\n double:{Double_1}\n decimal:{Decimal_1}\nchar:{Char_1}\nstring:{String_1}\nobject:{Object_1}\ndynamic:{Dynamic_1} ");
//    /*b Выполните 5 операций явного и 5 неявного приведения.*/

//    /*Неявные преобразования(implicit conversion) за нас делает компилятор 
//     если проьразрвания от беззнакового типа меньшей разрядности к большей до спереди добавляются дополнительные нули (zero extension)
//    (единицами, если число отрицательное)*/

//    int int_ic = 5;
//    long long_ic = int_ic;

//    long long_ic2 = 7;
//    double double_ic = long_ic2;

//    char char_ic = '4';
//    ulong ulong_ic = char_ic;

//    float float_ic = 7.5F;//Суфикс F для формата с плав запятой
//    double double_ic_2 = float_ic;

//    byte byte_ic = 2;
//    decimal decimal_ic = byte_ic;

//    /*Явные преобразования (Explicit convertion)
//     Суть операции преобразования типов состоит в том, что перед значением указывается в скобках тип, 
//    к которому надо привести данное значение:*/

//    int int_ec = 67;
//    char char_ec = (char)int_ec;

//    double double_ec_1 = 66.5;
//    double double_ec_2 = 77.7;
//    float float_ec = (float)(double_ec_1 + double_ec_2);

//    long long_ec = 6;
//    int int_ec_1 = (int)long_ec;

//    byte byte_ec = 3;
//    char char_ec_1 = (char)byte_ec;

//    uint uint_ec_1 = 1103;
//    uint uint_ec_2 = 4302;
//    short short_ec_1 = (short)(uint_ec_1 - uint_ec_2);


//    /*c. Выполните упаковку и распаковку значимых типов*/
//    /* Упаковка это преобразование value(значимого) типа в Object тип
//    Object тип это ссылочный (reference) тип.
//    Object и object это синонимы.*/
//    int int_o = 77;
//    Object obj_i = int_o;//упаковка
//    int int_o2 = (int)obj_i;

//    long long_o = 99;
//    Object obj_o = long_o;//упаковка
//    long long_o2 = (long)obj_o;

//    char char_o = '8';
//    Object obj_c = char_o;//упаковка
//    char char_o2 = (char)obj_c;
//    /*d. Продемонстрируйте работу с неявно типизированной
//    переменной.*/
//    var a = 5;
//    var b = 12;
//    var c = a + b;
//    /*e. Продемонстрируйте пример работы с Nullable переменной*/

//    int? int_null = null;
//    int_null = 5;
//    bool? bool_null = null;
//    /*f. . Определите переменную типа var и присвойте ей любое
//    значение. Затем следующей инструкцией присвойте ей значение
//    другого типа. Объясните причину ошибки.*/

//    // var var_1 = 4;
//    //var_1 = "rrrrr";
//    //Ошибка в строгости типизированния var , ей уже был присовен свой тип Int, и присвоить другой тип невозможно



//    /*СТРОКИ*/
//    /*. а Объявите строковые литералы. Сравните их.
//     отрицательное => первая строка предшествует второй в порядке сортировке или первая строка null
//     0 => первая и вторая строки равны -или- обе строки null
//     положительное число => первая строка следует за второй в порядке сортировки
//     1 => Вторая строка имеет значение null*/
//    string str_1 = "hello";
//    string str_2 = "Goodbye";
//    int int_str1_str2 = str_1.CompareTo(str_2);
//    Console.WriteLine(int_str1_str2);


//    /*Создайте три строки на основе String. Выполните: сцепление, 
//    копирование, выделение подстроки, разделение строки на слова, 
//    вставки подстроки в заданную позицию, удаление заданной 
//    подстроки.  Продемонстрируйте 
//    интерполирование строк.
//    String это класс(объект) в отличии от типа данных */

//    String string_b1 = "hello my name is Vera";
//    String string_b2 = "many bees are flying";
//    String string_b3 = "Sun is shuning";

//    ////сцепление конкатенация 2 способа
//    String string_b1_b2 = string_b1 + " " + string_b2;
//    //string[] value = new string[] { string_b1, string_b2 };
//    // String string_b1_b2 = String.Join(" ", value);


//    //// копирование
//    ////метод Copy устарел
//    String string_b3_copy = string_b3.Substring(0, string_b3.IndexOf("S") + 14);

//    ////выделение подстроки
//    String string__ = string_b1.Substring(0, string_b1.IndexOf("s"));
//    ////вставка подстроки в заданную позицию 
//    String string_in_string = "hhhhhhh";
//    string_in_string = string_in_string.Insert(3, string__);
//    ////Удаление заданной подстроки 
//    String string_remove = "abcdefgklmqb";
//    string_remove = string_remove.Remove(2, 4);

//    ////Демонстрация интеполирования строк 
//    Console.WriteLine($"сцепление: {string_b1_b2} \n Копирование: {string_b3_copy}\n выделение подстроки: {string__}\n вставкаподстроки в заданную позицию: {string_in_string}\n удаление заданной подстроки: {string_remove}");


//    /* Создайте пустую и null строку. Продемонстрируйте 
//    использование метода string.IsNullOrEmpty. Продемонстрируйте 
//    что еще можно выполнить с такими строками*/

//    string string_empty = "";
//    string str_null = null;

//    Console.WriteLine("string_empty " + String.IsNullOrEmpty(string_empty));
//    Console.WriteLine("str_null " + String.IsNullOrEmpty(str_null));

//    /*d. Создайте строку на основе StringBuilder. Удалите определенные 
//    позиции и добавьте новые символы в начало и конец строки.
//    */

//    //создание строки
//    StringBuilder str_SB = new StringBuilder("SOMETHING", 40);
//    Console.WriteLine(str_SB);

//    //удаление некоторых символов
//    str_SB.Replace("O", "");
//    str_SB.Replace("T", "");
//    Console.WriteLine(str_SB);

//    //добавление символов в начало строки
//    str_SB.Insert(0, "TEXT ");
//    Console.WriteLine(str_SB);

//    //добавление символов в конест строки
//    str_SB.Append("  HELLO");
//    Console.WriteLine(str_SB);

//    /*МАССИВЫ*/

//    /*Создайте целый двумерный массив и выведите его на консоль в
//    отформатированном виде(матрица).*/

//    int[,] num = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
//    for (int i = 0; i < 2; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {
//            Console.Write(num[i, j] + " ");
//        }
//        Console.WriteLine("\n");
//    }

//    /*b. Создайте одномерный массив строк. Выведите на консоль его
//    содержимое, длину массива. Поменяйте произвольный элемент
//    (пользователь определяет позицию и значение).*/

//    string[] str_massive = new string[] { "hello", "what", "name" };

//    foreach (string i in str_massive)
//    {
//        Console.WriteLine(i);
//    }

//    Console.WriteLine("Длинна массива str_massive :" + str_massive.Length);


//    Console.WriteLine("Введите номер элемента который хотите изменить");
//    int int_num_massive = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Введите строку");
//    string str_massive_new = Console.ReadLine();

//    str_massive[int_num_massive] = str_massive_new;


//    foreach (string i in str_massive)
//    {
//        Console.WriteLine(i);
//    }



//    /*c. Создайте ступечатый (не выровненный) массив вещественных
//    чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов
//    соответственно. Значения массива введите с консоли*/


//    float[][] massive_float = new float[3][];
//    massive_float[0] = new float[2];
//    massive_float[1] = new float[3];
//    massive_float[2] = new float[4];


//    for (int i = 0; i < massive_float.Length; i++)
//    {
//        for (int j = 0; j < massive_float[i].Length; j++)
//        {
//            Console.WriteLine("Введите число ");
//            massive_float[i][j] = Convert.ToSingle(Console.ReadLine());
//        }
//        Console.WriteLine();
//    }

//    for (int i = 0; i < massive_float.Length; i++)
//    {
//        for (int j = 0; j < massive_float[i].Length; j++)
//        {
//            Console.Write(massive_float[i][j]);

//        }
//        Console.WriteLine();
//    }


//    /*d. Создайте неявно типизированные переменные для хранения
//    массива и строки.*/
//    int[] array_int = new int[4];
//    var array = array_int;

//    string str_var = "irnvirn";
//    var var_STRING = str_var;

//    //КОРТЕЖИ

//    /*Задайте кортеж из 5 элементов с типами int, string, char, string,
//    ulong. */

//    (int, string, char, string, ulong) Cor = (5, "HELLO", 'r', "GOODbye", 1);

//    /*Выведите кортеж на консоль целиком и выборочно(например 1,
//    3, 4 элементы)*/

//    Console.WriteLine(Cor);
//    Console.WriteLine(Cor.Item1);
//    Console.WriteLine(Cor.Item3);
//    Console.WriteLine(Cor.Item4);

//    /*c. Выполните распаковку кортежа в переменные.
//    Продемонстрируйте различные способы распаковки кортежа.
//    Продемонстрируйте использование переменной ( _ ). (доступно
//    начиная с C#7.3)
//*/

//    _ = 8;


//    int n; string s, st; char ch; ulong ul;
//    (n, s, ch, st, ul) = Cor;


//    //(int n, string st, char ch_, string str, ulong ul) = Cor;

//    //через Var

//    //(var n, var st, var ch_, var str, var ul) = Cor;

//    /*d. Сравните два кортежа.*/
//    (int, string, char, string, ulong) Cor_1 = (22, "HELLO", 'r', "GOODbye", 1);
//    bool h = true;
//    if (Cor == Cor_1)
//    {
//        h = true;
//    }
//    else
//    {
//        h = false;
//    }
//    Console.WriteLine(h);


//    /*5) Создайте локальную функцию в main и вызовите ее
//     Формальные параметры функции – массив
//    целых и строка. Функция должна вернуть кортеж, содержащий:
//    максимальный и минимальный элементы массива, сумму элементов
//    массива и первую букву строки .*/

//    static (int, int, int, char) funct(int[] array__, string str_0)
//    {
//        int min = array__[0];
//        int max = array__[0];
//        int sum = array__[0];
//        foreach (int i in array__)
//        {
//            if (i > max) { max = i; }
//            if (i < min) { min = i; }
//            sum = sum + i;

//        }


//        return (max, min, sum, str_0[0]);
//    }


//    var t = funct(new int[] { 1, 2, 3, 4, 4 }, "Hemfh");
//    Console.WriteLine(t);

//    /*CHECKED*/
//    /*a. Определите две локальные функции.
//     b. Разместите в одной из них блок checked, в котором определите
//     переменную типа int с максимальным возможным значением
//     этого типа. Во второй функции определите блок unchecked с
//     таким же содержимым
//     c. Вызовите две функции. Проанализируйте результат. */

//    static void e()
//    {
//        int a = checked(int.MaxValue);

//    }
//    static void e_()
//    {
//        int a = unchecked(int.MaxValue);
//    }

//    e();
//    e_();


//class A
//{
//int c = 6;
//    // public A() { }

//    // public A(int somel) { } 
//    //public A(A somA) { }
//    public int A() { }


//}

 class Points
{
    public readonly int a = 10;
    public static readonly Int32 b = new Int32();
    public static string c = "New";
    private int d;

    public Points()
    {
        c = "Method";
        a = 20;
        b = 30;//эта т.к она наз-я d
    }
}



