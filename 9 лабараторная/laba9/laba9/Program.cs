using System;
/*Создать класс Игра с событиями Атака и Лечить. В main создать
некоторое количество игровых объектов. Подпишите объекты на 
события произвольным образом. Реакция на события у разных
объектов может быть разной (без изменения,
увеличивается/уменьшается уровень жизни). Проверить состояния
игровых объектов после наступления событий, возможно не
однократном.*/
namespace laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            Game[] Games = new Game[4];
            Games[0] = new Game();
            Games[1] = new Game();
            Games[2] = new Game();
            Games[3] = new Game();

            Games[0].Atack += (game, action) => Console.WriteLine($"В игре {game} произошла атака на {action} очков");
            Games[0].Treat += (game, recovery) => Console.WriteLine($"В игре {game} произошло лечение на {recovery} очков");

            Games[2].Treat += (game, recovery) => Console.WriteLine($"В игре {game} произошло лечение на {recovery} очков");
            Games[3].Atack += (game, action) => Console.WriteLine($"В игре {game} произошла атака на {action} очков");


            Random rand_ = new Random();

            foreach(Game i in Games)
            {
                i.atack(i, rand_.Next());
                i.treat(i, rand_.Next());
            }
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            /*СТРОКА2. Создайте пять методов пользовательской обработки строки (например,
            удаление знаков препинания, добавление символов, замена на заглавные,
            удаление лишних пробелов и т.п.). Используя стандартные типы делегатов
            (Action, Func) организуйте алгоритм последовательной обработки строки
            написанными вами методами. Далее приведен перечень заданий.*/
            string String = "rccccvvv  AAA!";
            StringDeformate str = new StringDeformate();

            Func<string, string> DELEGATE = str => str.ToLower();// В нижний регистр
            String = DELEGATE(String);
            Console.WriteLine(String);

            //
            DELEGATE += str => str.ToUpper();//Верхний регистр
            String = DELEGATE(String);
            Console.WriteLine(String);
            //
            DELEGATE += str.RemovePunctuationMarks;// убрать пунктуацию
            String = DELEGATE(String);
            Console.WriteLine(String);
            //
            DELEGATE += str.SpaceDelete;//Убрать лишний проблеы
            String = DELEGATE(String);
            Console.WriteLine(String);
            //
            Func<string, char, string> NOTPARAMS = (str, ch) => str += ch;
            String = NOTPARAMS(String, 'V');//Добавление символа
            Console.WriteLine(String);

        }






        class Game
        {
            public delegate void Operation(Game game, int param);
            public event Operation Atack;// Событие атака
            public event Operation Treat;//Событие лечить

            public string str { get; set; }

            public void atack(Game game, int action)
            {
                if (Atack == null)
                {
                    Console.WriteLine("произошлоа АТАКА");
                }
                else Atack(game, action);
            }
            public void treat(Game game, int recovery)
            {
                if (Treat == null)
                {
                    Console.WriteLine("произошло ЛЕЧЕНИЕ");
                }
                else Treat(game, recovery);
            }

        }


        class StringDeformate
        {
            public string RemovePunctuationMarks(string str)
            {
                string PunctuatinMarks = ",.;:-!";
                for (int i = 0; i < str.Length; i++)
                {
                    foreach (char PunctuationMark in PunctuatinMarks)
                        if (str[i] == PunctuationMark)
                            str = str.Remove(i, 1);
                }
                return str;
            }
            public string SpaceDelete(string str)
            {
                for (int i = 0; i < str.Length; i++)
                    if (str[i] == ' ' && str[i + 1] == ' ')
                        str = str.Remove(i + 1, 1);
                return str;
            }
        }





    }
}
