/*findMax() – функция поиска максимального  элемента списка по одному из выбранных полей. */

#include <iostream>
#include <fstream>
#include <sstream>
using namespace std;
const unsigned int NAME_SIZE = 30;
const unsigned int KOLVO_Product_SIZE = 20;

struct Address
{
	char name_of_products[NAME_SIZE];
	char kol_vo_prod[KOLVO_Product_SIZE];
	Address* next;
	Address* prev;
};
//-----------------------------------------------------------
int menu(void)
{
	char s[80];  int c;
	cout << endl;
	cout << "1. Ввод имени" << endl;
	cout << "2. Удаление имени" << endl;
	cout << "3. Вывод на экран" << endl;
	cout << "4. Поиск" << endl;
	cout << "5. Выход" << endl;
	cout << endl;
	do
	{
		cout << "Ваш выбор: ";
		cin.sync();
		gets_s(s);
		cout << endl;
		c = atoi(s);
	} while (c < 0 || c > 5);
	return c;
}
//-----------------------------------------------------------
void insert(Address* e, Address** phead, Address** plast) //Добавление в конец списка
{
	Address* p = *plast;
	if (*plast == NULL)
	{
		e->next = NULL;
		e->prev = NULL;
		*plast = e;
		*phead = e;
		return;
	}
	else
	{
		p->next = e;
		e->next = NULL;
		e->prev = p;
		*plast = e;
	}
}
//-----------------------------------------------------------
Address* setElement()      // Создание элемента и ввод его значений с клавиатуры 
{
	Address* temp = new  Address();
	if (!temp)
	{
		cerr << "Ошибка выделения памяти памяти";

		return NULL;
	}
	cout << "Введите название продукта: ";
	cin.getline(temp->name_of_products, NAME_SIZE - 1, '\n');
	cin.ignore(cin.rdbuf()->in_avail());
	cin.clear();
	cout << "Введите количество продукт(кг): ";
	cin.getline(temp->kol_vo_prod, KOLVO_Product_SIZE - 1, '\n');
	cin.ignore(cin.rdbuf()->in_avail());
	cin.clear();
	temp->next = NULL;
	temp->prev = NULL;
	return temp;
}
//-----------------------------------------------------------
void outputList(Address** phead, Address** plast)      //Вывод списка на экран
{
	Address* t = *phead;
	while (t)
	{	
		cout << t->name_of_products << ' ' << t->kol_vo_prod << endl;
		t = t->next;
	}
	cout << "" << endl;
}
//-----------------------------------------------------------
void find(char name[NAME_SIZE], Address** phead)    // Поиск имени в списке
{
	Address* t = *phead;
	Address* k = *phead;
	string str_1 = t->kol_vo_prod;
	int num_max = 0;
	stringstream ss;
	ss << str_1;
	ss >> num_max;
	string name_1 = k->name_of_products;
	while (t)
	{
		string str = t->kol_vo_prod;
		string name = k->name_of_products;
		int num = 0;
		stringstream ss;
		ss << str;
		ss >> num;
		cout << num << " " << endl;
		t = t->next;
		if (num_max < num) {
			num_max = num;
			name_1 = name;
		}
		t->next;
		k->next;
	}
	cout << "максимальное количество продукта  " << name_1 << " " << num_max << endl;
}
//-----------------------------------------------------------
void delet(char name[NAME_SIZE], Address** phead, Address** plast) {
	Address* t = *phead;
	while (t) {
		if (!strcmp(name, t->name_of_products))  break;
		t = t->next;
	}
	if (!t) {
		cerr << "Продукт не найден " << endl;
	}

	else {
		if (*phead == t)
		{
			*phead = t->next;
			if (*phead) {
				(*phead)->prev = NULL;
			}
			else {
				*plast = NULL;
			}
		}
		else
		{
			t->prev->next = t->next;
			if (t != *plast) {
				t->next->prev = t->prev;
			}
			else {
				*plast = t->prev;
			}
		}
		delete t;

		cout << "Элемент удален" << endl;
	}

}  // Удаление имени {	struct Address *t = *phead;	

//-----------------------------------------------------------
int main(void)
{
	Address* head = NULL;
	Address* last = NULL;
	setlocale(LC_CTYPE, "Rus");
	while (true)
	{
		switch (menu())
		{
		case 1:  insert(setElement(), &head, &last);
			break;
		case 2: {	  char dname[NAME_SIZE];
			cout << "Введите продукт: ";
			cin.getline(dname, NAME_SIZE - 1, '\n');
			cin.ignore(cin.rdbuf()->in_avail());
			cin.sync();
			delet(dname, &head, &last);
		}
			  break;
		case 3:  outputList(&head, &last);
			break;
		case 4: {	  char fname[NAME_SIZE];
			find(fname, &head);
		}
			  break;
		case 5:  exit(0);
		default: exit(1);
		}
	}
	return 0;
}
