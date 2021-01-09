#include <iostream>
using namespace std;

int main() {
    setlocale(LC_ALL, "Russian");
    int n;
    printf("Введите число P\n");
    scanf_s("%i", &n);
    int k = 1;
    float s = 1000;
    while (s <= 1100) {
        ++k;
        s += s * n / 100;
    }
    printf("k = %i", s);
    return 0;
}