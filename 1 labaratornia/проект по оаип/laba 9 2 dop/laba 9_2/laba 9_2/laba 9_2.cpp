/*Каждый элемент списка студентов содержит фамилию, имя, отчество, год рождения, курс, номер группы, оценки по пяти предметам.
Упорядочить студентов по курсу, причем студенты одного курса должны располагаться в алфавитном порядке. Найти средний балл каждой группы по каждому предмету.
Определить самого старшего студента и самого младшего студентов. Для каждой группы найти лучшего с точки зрения успеваемости студента.*/
#include<iostream>
#include<algorithm>
using namespace std;
struct STRUCTURA
{
	int value;
	char NAME[30] = {};
	char SURNAME[30] = {};
	char OTCHESTVO[30] = {};
	int year;
	int course;
	int group;
	int OTSENKA[5];
	float sr_ball = 0;

	STRUCTURA* next;
	STRUCTURA* prev;

};
STRUCTURA* plist = NULL;
STRUCTURA* p;
STRUCTURA* plist1 = NULL;
STRUCTURA* p1;
int flag_1 = 0;
int flag = 1;//f
void ADD_TO()
{
	cout << "SUCCESS" << endl;
	char fname[50];
	char sname[50];
	char thname[50];
	cout << "ФИО студента :";
	cin >> fname >> sname >> thname;
	int year;

	cout << "Введите год рождения :";
	cin >> year;
	int group, course, marks[5];
	cout << "Введите курс и номер группы :";
	cin >> course >> group;
	for (int i = 0; i < 5; i++)
	{
		cout << "Оценка " << i + 1 << " :";
		cin >> marks[i];
	}
	p = new STRUCTURA;
	for (int i = 0; i < strlen(fname); i++)
	{
		p->NAME[i] = fname[i];
	}
	for (int i = 0; i < strlen(sname); i++)
	{
		p->SURNAME[i] = sname[i];
	}
	for (int i = 0; i < strlen(thname); i++)
	{
		p->OTCHESTVO[i] = thname[i];
	}
	p->year = year;
	p->course = course;
	p->group = group;
	for (int i = 0; i < 5; i++)
	{
		p->OTSENKA[i] = marks[i];
		p->sr_ball += marks[i];
	}
	p->sr_ball /= 5;
	p->next = plist;
	p->prev = NULL;
	if (p->next != NULL)
	{
		STRUCTURA* previ;
		previ = p;
		p = p->next;
		p->prev = previ;
		p = previ;
	}
	plist = p;
	flag_1++;
	cout << "SUCCESS" << endl;
	cout << "\t\t\t\t" << endl;
	return;
}
void Sort()
{
	cout << "\t\t\t\t" << endl;
	int val = flag_1 - 1;
	for (int i = 0; i < flag_1; i++)
	{
		STRUCTURA* host1 = p;
		STRUCTURA* host2 = p->next;
		for (int j = 0; j < val; j++)
		{
			if (host1->course < host2->course)
			{
				swap(host1->NAME, host2->NAME);
				swap(host1->SURNAME, host2->SURNAME);
				swap(host1->OTCHESTVO, host2->OTCHESTVO);
				swap(host1->course, host2->course);
				swap(host1->group, host2->group);
				swap(host1->year, host2->year);
				swap(host1->OTSENKA, host2->OTSENKA);
				swap(host1->sr_ball, host2->sr_ball);
			}
			host1 = host1->next;
			host2 = host2->next;
		}
		val--;
	}
	cout << "SUCCESS!" << endl;
	cout << "\t\t\t\t" << endl;
}
void write()
{
	cout << "\t\t\t\t" << endl;
	STRUCTURA* host = p;
	for (int i = 0; i < flag_1; i++)
	{
		cout << "ФИО : " << host->NAME << " " << host->SURNAME << " " << host->OTCHESTVO << endl;
		cout << "Год рождения : " << host->year << " Курс : " << host->course << " Группа : " << host->group << endl;
		cout << "Оценки : " << host->OTSENKA[0] << " " << host->OTSENKA[1] << " " << host->OTSENKA[2] << " " << host->OTSENKA[3] << " " << host->OTSENKA[4] << endl;
		host = host->next;
		cout << endl;
	}
	cout << "\t\t\t\t" << endl;
}

void better_student()
{
	cout << "\t\t\t\t" << endl;
	STRUCTURA* host = p;
	int max_mark = host->sr_ball;
	STRUCTURA* better = host;
	for (int i = 0; i < flag_1; i++)
	{
		if (max_mark < host->sr_ball)
		{
			max_mark = host->sr_ball;
			better = host;
		}
		host = host->next;
	}
	cout << "Лучший по успеваемсти " << better->NAME << " " << better->SURNAME << " " << better->OTCHESTVO << endl;
	cout << "\t\t\t" << endl;
}
void max_min_year()
{
	cout << "\t\t\t" << endl;
	STRUCTURA* host = p;
	int ma = host->year;
	int mi = host->year;
	STRUCTURA* mi_st = host;
	STRUCTURA* ma_st = host;
	for (int i = 0; i < flag_1; i++)
	{
		if (ma < host->year)
		{
			ma = host->year;
			ma_st = host;
		}
		if (mi > host->year)
		{
			mi = host->year;
			mi_st = host;
		}
		host = host->next;
	}

	cout << "Самый младший студент : " << mi_st->NAME << " " << mi_st->SURNAME << " " << mi_st->OTCHESTVO << endl;
	cout << "Самый старший студент : " << ma_st->NAME << " " << ma_st->SURNAME << " " << ma_st->OTCHESTVO << endl;
	cout << "\t\t\t" << endl;
}
void middle_groups()
{
	cout << "\t\t\t" << endl;
	STRUCTURA* ho = p;
	for (int i = 0; i < flag_1; i++)
	{
		p1 = new STRUCTURA;
		for (int i = 0; i < strlen(ho->NAME); i++)
		{
			p1->NAME[i] = ho->NAME[i];
		}
		for (int i = 0; i < strlen(ho->SURNAME); i++)
		{
			p1->SURNAME[i] = ho->SURNAME[i];
		}
		for (int i = 0; i < strlen(ho->OTCHESTVO); i++)
		{
			p1->OTCHESTVO[i] = ho->OTCHESTVO[i];
		}
		p1->year = ho->year;
		p1->course = ho->course;
		p1->group = ho->group;
		for (int i = 0; i < 5; i++)
		{
			p1->OTSENKA[i] = ho->OTSENKA[i];
		}
		p1->sr_ball = ho->sr_ball;
		p1->next = plist1;
		p1->prev = NULL;
		if (p1->next != NULL)
		{
			STRUCTURA* previ;
			previ = p1;
			p1 = p1->next;
			p1->prev = previ;
			p1 = previ;
		}
		plist1 = p1;
		ho = ho->next;
	}

	int val = flag_1 - 1;
	for (int i = 0; i < flag_1; i++)
	{
		STRUCTURA* host11 = p1;
		STRUCTURA* host22 = p1->next;
		for (int j = 0; j < val; j++)
		{
			if (host11->group < host22->group)
			{
				swap(host11->NAME, host22->NAME);
				swap(host11->SURNAME, host22->SURNAME);
				swap(host11->OTCHESTVO, host22->OTCHESTVO);
				swap(host11->course, host22->course);
				swap(host11->group, host22->group);
				swap(host11->year, host22->year);
				swap(host11->OTSENKA, host22->OTSENKA);
				swap(host11->sr_ball, host22->sr_ball);
			}
			host11 = host11->next;
			host22 = host22->next;

		}
		val--;
	}

	STRUCTURA* host = p1;

	STRUCTURA* best = host;
	int ma = host->sr_ball, gr = host->group;
	for (int i = 0; i < flag_1; i++)
	{
		if (host->group != gr)
		{
			cout << "Студент группы №" << gr << " лучший : " << best->NAME << " " << best->SURNAME << " " << best->OTCHESTVO << endl;
			gr = host->group;
			ma = host->sr_ball;
			best = host;
		}
		if (ma < host->sr_ball)
		{
			ma = host->sr_ball;
			gr = host->group;
			best = host;
		}
		if (i != flag_1 - 1)host = host->next;
	}
	if (ma < host->sr_ball)
	{
		ma = host->sr_ball;
		gr = host->group;
		best = host;
	}
	cout << "Студент группы №" << gr << " Самая высокая успеваемость : " << best->NAME << " " << best->SURNAME << " " << best->OTCHESTVO << endl;



	cout << "\t\t\t\t" << endl;
}
void main()
{
	setlocale(LC_CTYPE, "Rus");
	int c;
	do {
		cout << "\t\t\t\t" << endl;
		cout << "1. Добавить студента" << endl;
		cout << "2. Вывод студентов" << endl;
		cout << "3. Курс" << endl;
		cout << "4. Лучшая успеваемость" << endl;
		cout << "5. Максимальный и минимальный год рождения" << endl;
		cout << "6. Средний балл" << endl;
		cout << "7. Выход" << endl;
		cout << "Выбор: ";
		cin >> c;
		switch (c)
		{
		case 1:
			ADD_TO();
			break;
		case 2:
			write();
			break;
		case 3:
			Sort();
			break;
		case 4:
			better_student();
			break;
		case 5:
			max_min_year();
			break;
		case 6:
			middle_groups();
			break;
		case 7:;
			break;
		default:
			cout << "ERROR" << endl;
			break;
		}
		cout << "\t\t\t\t\t\t\t" << endl;
		cout << endl;
	} while (c != 7);
}
