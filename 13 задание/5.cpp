#include <locale.h>
#include <stdio.h>
int main(void) {
	setlocale(LC_ALL, "Rus");
	float a, s, k;
	int n, i;
	printf("Введите вещественное число A и целое число N \n");
	scanf_s("%f %i", &a, &n);
	s = 1;
	k = a * (-1);
	a = k;
	for (i = 0; i < n; i++) {
		s = s + a;
		a = a * k;
		printf("%.2f\n", s);
	}
	return 0;
}
