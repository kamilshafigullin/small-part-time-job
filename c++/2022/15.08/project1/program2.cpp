#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    float x, y;
    cout << "Введите первое число: ";
    cin >> x;
    cout << "Введите второе число: ";
    cin >> y;
    float averageCube = (x*x*x+y*y*y) / 2;
    float averageGeom = pow(abs(x)*abs(y), 1.0/2);
    cout << "Среднее арифметическое кубов чисел: " << averageCube << endl;
    cout << "Среднее геометрическое модулей чисел: " << averageGeom << endl;
}