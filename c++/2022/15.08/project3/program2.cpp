// Дано действительно число x. Вычислить *
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
    float x;
    cout << "Введите x: ";
    cin >> x;
    float result = 0;

    for (int i = 1; i <= 13; i += 2)
    {
        float c = pow(x, i) / get_factorial(i);
        if (i == 3 || i == 7 || i == 11)
            result -= c;
        else
            result += c;
    }

    cout << "Результат: " << result << endl;
}