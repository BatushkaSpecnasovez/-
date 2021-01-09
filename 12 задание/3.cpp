﻿// ConsoleApplication2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <stdio.h>
#include <locale.h>

int main(void) {
	setlocale(LC_ALL, "Rus");
	int n, ost;
	char test[][16] = { "одно ", "два ", "три ", "четыре ", "пять ", "шесть ", "семь ", "восемь ", "девять " };
	char slov[][21] = { "учебных заданий", "учебное задание", "учебных задания", "учебных задания", "учебных задания", "учебных заданий", "учебных заданий" , "учебных заданий" ,"учебных заданий" ,"учебных заданий" };
	char chis[][13] = { "Десять", "Одиннадцать", "Двенадцать", "Тринадцать", "Четырнадцать", "Пятнадцать", "Шестнадцать", "Семнадцать", "Восемнадцать", "Девятнадцать", "Двадцать" };
	char des[][10] = { "Двадцать ", "Тридцать ", "Сорок " };
	printf("Введите количество заданий\n");
	scanf_s("%i", &n);
	if ((n > 9) && (n < 21)) {
		n = n - 9;
		printf("%s ", chis[n-1]);
		printf("%s", slov[0]);
	}
	else {
		ost = (float)n / 10;
		printf("%s", des[ost - 2]);
		ost = n % 10;
		if (n != 0) {
			printf("%s", test[ost-1]);
		}
		printf("%s", slov[ost]);
	}
	return 0;
}
