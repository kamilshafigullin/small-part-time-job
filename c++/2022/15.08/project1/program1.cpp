#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    float x, y;
    cout << "Введите x: ";
    cin >> x;
    cout << "Введите y: ";
    cin >> y;

    float e = exp(1.0);
    float result = (3 + pow(e, y-1))/(1+x*x*abs(y-tan(x)));
    cout << "Результат: " << result << endl;
}