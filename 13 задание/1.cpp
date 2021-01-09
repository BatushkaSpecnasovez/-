#include <iostream>
using namespace std;
#include <stdio.h>
int main()
{
	setlocale(LC_ALL, "Rus");
	float c, m;
	cout << "Введите стоимость 1 кг конфет:";
	cin >> c;
	cout << "Стоимость конфет" << endl;
	for (m = 0.1; m < 1.1; m += 0.1)
		cout << m << " kg = " << c * m << endl;
	return 0;
}