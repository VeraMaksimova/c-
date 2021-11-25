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
        {

        }

        /**/
        class StudentEnumerator : IEnumerator
        {
            Queue<string> Student_names = new Queue<string>();
            int position = -1;
            public StudentEnumerator(Queue<string> Student_names)
            {
                this.Student_names = Student_names;
            }

            public object Current
            {
                get
                {
                    GetHashCode();
                }
            }
            public bool MoveNext()
            {
                //очередь след элемент
            }

            public void Reset()
            {
                position = -1;
            }
        }
        class Student
        {
            Queue<string> Student_names = new Queue<string>();

            public IEnumerator GetEnumerator()
            {
                return new StudentEnumerator(Student_names);
            }
        }
        /**/









    }
}
        