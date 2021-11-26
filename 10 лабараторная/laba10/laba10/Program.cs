using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ЛР__10
{
    class Program
    {
        static void Main(string[] args)
        {   //Dequeue: извлекает и возвращает первый элемент очереди
            //Enqueue: добавляет элемент в конец очереди
            //Peek: просто возвращает первый элемент из начала очереди без его удаления
            //ДОБАВЛЕНИЕ СТУДЕНТОВ
            Queue<Student> Students = new Queue<Student>();
            Students.Enqueue( new Student { Name = "Саша", Kurs = 2, Gruppa = 4 });
            Students.Enqueue(new Student { Name = "Аня", Kurs = 3, Gruppa = 3 });
            Students.Enqueue(new Student { Name = "Павел", Kurs = 1, Gruppa = 1 });
            Students.Enqueue(new Student { Name = "Екатерина", Kurs = 4, Gruppa = 5 });
            Students.Enqueue(new Student { Name = "Никита", Kurs = 2, Gruppa = 3 });
            //ПОЛУЧАЕМ ПЕРВЫЙ ЭЛЕМЕНТ БЕЗ ИЗВЛЕЧЕНИЯ
            //Student ss = Students.Peek();
            //Console.WriteLine(ss.Name);
            //перечисление студентов и поиск по группе
            Console.WriteLine("Введите имя  для поиска ");
            string Search  = Console.ReadLine();
            
            foreach (Student s in Students)
            {   if(Search == s.Name) {
                    Console.WriteLine("Имя: " + s.Name);
                    Console.WriteLine("Курс: " + s.Kurs);
                    Console.WriteLine("Группа: " + s.Gruppa);
                    Console.WriteLine("----------");
                }
            }
            //Извлечение элемента из очереди 
            Student student = Students.Dequeue(); 
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Gruppa);
            Console.WriteLine(student.Kurs);
            int i = 0;
            List<int> list = new List<int>(10);
            // Добавление элементов
            foreach (int s in list)
            {
                i = i + 1;
                list.Add(i);
            }
            //Удалениее четных
            foreach (int s in list)
            {
                i = i + 2;
                list.Remove(i);
            }

            //Вторая коллекция
            Stack<Student> study = new Stack<Student>();
            //Добавить 
            study.Push(new Student { Name = "Саша", Kurs = 2, Gruppa = 4 });
            study.Push(new Student { Name = "Аня", Kurs = 3, Gruppa = 3 });
            study.Push(new Student { Name = "Павел", Kurs = 1, Gruppa = 1 });
            study.Push(new Student { Name = "Екатерина", Kurs = 4, Gruppa = 5 });
            study.Push(new Student { Name = "Никита", Kurs = 2, Gruppa = 3 });
            //Поиск
            Console.WriteLine("Введите имя  для поиска ");
            string SearchSTACK = Console.ReadLine();
            foreach (Student s in study)
            {
                if (SearchSTACK == s.Name)
                {
                    Console.WriteLine("Имя: " + s.Name);
                    Console.WriteLine("Курс: " + s.Kurs);
                    Console.WriteLine("Группа: " + s.Gruppa);
                    Console.WriteLine("----------");
                }
            }
            /////ObservableCollection<T>
            ObservableCollection<Student> students_collection = new ObservableCollection<Student>
            {
                new Student { Name = "Bill", Gruppa = 2, Kurs = 3},
                new Student { Name = "An", Gruppa = 2, Kurs = 3},
                new Student { Name = "Honey", Gruppa = 4, Kurs = 3}
            };

            students_collection.CollectionChanged += Students_CollectionChanged;

            students_collection.Add(new Student { Name = "Bob" });
            students_collection.RemoveAt(1);
            students_collection[0] = new Student { Name = "Anders" };

            foreach (Student s in students_collection)
            {
                Console.WriteLine(s.Name);
            }

        }
        private static void Students_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Student newUser = e.NewItems[0] as Student;
                    Console.WriteLine($"Добавлен новый объект: {newUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Student oldUser = e.OldItems[0] as Student;
                    Console.WriteLine($"Удален объект: {oldUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    Student replacedUser = e.OldItems[0] as Student;
                    Student replacingUser = e.NewItems[0] as Student;
                    Console.WriteLine($"Объект {replacedUser.Name} заменен объектом {replacingUser.Name}");
                    break;
            }
        }

        class StudentEnumerator: IEnumerator
        {
            public string Name { get; set; }
            public int Gruppa { get; set; }
            public int Kurs { get; set; }
            int position = -1;
            public StudentEnumerator(string Name, int Gruppa, int Kurs)
            {
                this.Name = Name;
                this.Gruppa = Gruppa;
                this.Kurs = Kurs;
            }
            public object Current
            {
                get
                {
                    if (position == -1 || position >= Name.Length)
                        throw new InvalidOperationException();
                    return Name[position];
                }
            }
            public bool MoveNext()
            {
                if ((position < Name.Length - 1) )
                {
                    position++;
                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                position = -1;
            }

        }

        class Student : IEnumerable
        {
            public string Name { get; set; }
            public int Gruppa { get; set; }
            public int Kurs { get; set; }

            public IEnumerator GetEnumerator()
            {
                return new StudentEnumerator(Name, Gruppa, Kurs);
            }
        }
        
        









    }
}
        