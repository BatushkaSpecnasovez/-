﻿#include <iostream>
using namespace std;

int main() {
    setlocale(LC_ALL, "Russian");
    int n;
    printf("Введите целое число N\n");
    scanf_s("%i", &n);
    int f1 = 1, f2 = 1, f = 0, k = 2;
    while (f < n) {
        ++k;
        f = f2 + f1;
        f2 = f1;
        f1 = f;
    }
    cout << "k:" << k;
    return 0;
}