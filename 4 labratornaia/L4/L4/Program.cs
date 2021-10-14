using System;
using System.Buffers;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Collections.Generic;


/*Класс  множество Set. Дополнительно перегрузить 
следующие операции: ->> удалить элемент из множества 
(типа set-item); >  проверка на подмножество; !=  проверка 
множеств на неравенство; <<  добавить элемент в множество 
(типа set+item);  
Методы расширения:
1) Поиск самого короткого слова
2) Упорядочивание множества*/
namespace Set
{
	public class Program
	{     

	}
	class Owner
	{
		public string name;
		public string organization;
		public uint id;
	}

	public class My_Set<T> 
	{
		private Owner person = new Owner {name = "Vera", organization = "BSTU", id = 0};
		//private Date date = new Date { date = (DateTime.Now).ToString() };
		private T[] set;
		private uint size;
		
		public T this[int index]
		{
			get{return set[index];}
			set{set[index] = value;}
		}
		public My_Set(uint Size)
		{
			this.set = new T[Size];
			size = Size;
		}
		//пересечение множеств
		public static bool operator %(My_Set<T> set1, My_Set<T> set2)
		{
			//T diff;
			bool t = false;
			if (set1 == null)
			{
				throw new ArgumentNullException(nameof(set1));
			}

			if (set2 == null)
			{
				throw new ArgumentNullException(nameof(set2));
			}
			//выбор наименьшего множества
			if(set1.size < set2.size)
            {
			
				for (int i = 0; i < set1.size; i++)
                {
					for (int j = 0; j < set2.size; j++)
					{
						if (Convert.ToDouble(set1[i]) == Convert.ToDouble(set2[j])) { t = true; } 
					}
				}
			}
			if (set2.size < set1.size)
			{

				for (int i = 0; i < set2.size; i++)
				{
					for (int j = 0; j < set1.size; j++)
					{
						if (Convert.ToDouble(set1[i]) == Convert.ToDouble(set2[j])) { t = true; }
					}
				}
			}
			return t;
		}
		//<<  добавить элемент в множество (типа set+item)

		//public static My_Set<T> operator >>(My_Set<T> set1, int t)
		//{
		//	My_Set<T> Set = new My_Set<T>(set1.size + 1);

		//	for (int i = 0; i < Set.size; i++)
		//          {
		//		if(i == Set.size)
		//              {
		//			Convert.ToInt32(Set[i]) = Convert.ToInt32(t);
		//              }
		//          }

		//	return set1;
		//}


		//!= проверка множеств на неравенство;
		


	}



}