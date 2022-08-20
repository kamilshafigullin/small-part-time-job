// А. Написать программу для нахождения суммы большего и меньшего из трех чисел.
#include <iostream>

using namespace std;

int main()
{
    int a, b, c, low, high;
    cout << "Введите первое число: ";
    cin >> a;

    cout << "Введите второе число: ";
    cin >> b;

    cout << "Введите третье число: ";
    cin >> c;

    low = min(min(a, b), min(b, c));
    high = max(max(a, b), max(b, c));

    int sum = low + high;
    cout << "Сумма большего и меньшего из трёх чисел: " << sum << endl;
}