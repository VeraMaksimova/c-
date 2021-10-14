/*
3 ДОП
N человек  располагаются  по кругу.  Начав отсчет от первого, удаляют каждого k-го,
смыкая круг после удаления. Определить порядок удаления людей из круга. Использовать линейный список.*/
#include <iostream>
using namespace std;
struct PEOPLE
{
	char num[10];
	PEOPLE* next;
};
char* circle(PEOPLE*, int, int);
PEOPLE* MASSIVE(int);
int main()
{
	setlocale(LC_ALL, "rus");
	int kolichestvo;
	int г;
	cout << "КОЛИЧЕСТВО УЧАСТНИКОВ  ";
	cin >> kolichestvo;
	PEOPLE* g = MASSIVE(kolichestvo);
	cout << "Введите r: ";
	cin >> г;
	cout << "Последний: " << circle(g, г, kolichestvo) << endl;
	system("pause");
	return 0;
}
PEOPLE* MASSIVE(int kolv)
{
	PEOPLE* first = nullptr;
	PEOPLE* Head;
	PEOPLE* nowiy;
	char a[10];
	if (kolv > 0)
	{
		nowiy = new PEOPLE;
		Head = nowiy;
	}
	else
	{
		return first;
	}
	for (int i = 0; i < kolv; i++)
	{
		cout << "Человек: ";
		cin >> a;
		for (int y = 0; y < 10; y++)
		{
			if (a[y] == '\0')
			{
				nowiy->num[y] = '\0';
				break;
			}
			nowiy->num[y] = a[y];
		}
		first = nowiy;
		nowiy = new PEOPLE;
		first->next = nowiy;
	}
	first->next = Head;
	return Head;
}
char* circle(PEOPLE* g, int ocher, int kolv)
{
	int u = 0;
	PEOPLE* buff;
	PEOPLE* h = g;
	while (h->next != h)
	{
		for (int i = 0; i < ocher - 2; i++)
		{
			h = h->next;
		}
		buff = h->next;
		cout << buff->num << endl;
		h->next = h->next->next;
		h = h->next;
		delete buff;
	}
	return h->num;
}