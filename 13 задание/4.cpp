#include <iostream>
using namespace std;

int main() {
    float a;
    cout << "A:";
    cin >> a;
    int n;
    cout << "N:";
    cin >> n;
    float a2 = 1, rez = 1;
    int i;
    for (i = 2; i <= n; ++i)
    {
        a2 *= a;
        rez += a2;
    }
    cout << rez;
}