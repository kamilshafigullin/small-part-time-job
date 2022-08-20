// Составить программу для вычисления значений функции F(x) на отрезке [а, b] с шагом h.
// Результат представить в виде таблицы, первый столбец которой — значения аргумента, второй — соответствующие значения функции.
// F(x) = ctg(x) + 1
#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    float a, b, h;
    cout << "Введите a: ";
    cin >> a;

    cout << "Введите b: ";
    cin >> b;

    cout << "Введите h: ";
    cin >> h;

    cout << "x\tF(x)" << endl;
    float x = a;
    while (x <= b)
    {
        float fx = 1.0 / tan(x) + 1;
        cout << x << "\t" << fx << endl;
        x += h;
    }
}