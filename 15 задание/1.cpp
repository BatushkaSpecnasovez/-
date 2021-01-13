#include <cstdio>
#include <locale.h>
void poweraA3(float a, float* b)
{
    *b = a * a * a;
}

int main(void)
{
    int i;
    setlocale(LC_ALL, "Rus");
    for (i = 1;i <= 5;++i) {
        float a;
        printf("Введите число \A:");
        scanf_s("%f", &a);
        float b;
        poweraA3(a, &b);
        printf("B: %f\n", b);
    }
    return 0;
}