// Вычислить значение функции
#include <iostream>

using namespace std;

int main()
{
    float x, result;
    cout << "Введите x: ";
    cin >> x;

    if (x <= 7)
        result = -3 * x + 9;
    else
        result = 1.0 / (x - 7);

    cout << "Значение функции: " << result << endl;
}