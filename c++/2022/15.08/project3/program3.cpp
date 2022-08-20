// Даны числовой ряд и некоторое число ε.
// Найти сумму тех членов ряда, модуль которых больше или равен заданному ε.
// Общий член ряда имеет вид: a(n) = 10^n/n!
#include <iostream>
#include <cmath>

using namespace std;

int get_factorial(int n)
{
    int factorial = 1;
    for (int i = 1; i <= n; i++)
        factorial *= i;
    return factorial;
}

int main()
{
    float e, b, h;
    cout << "Введите e: ";
    cin >> e;

    float sum = 0;
    int n = 1;
    while (abs(pow(10, n) / get_factorial(n)) >= e)
    {
        sum += n;
        n += 1;
    }

    cout << "Сумма: " << sum << endl;
}