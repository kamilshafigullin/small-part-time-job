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

    bool result = x >= 0 && x <= 4 && y >= 0 && y <= 4 && x*x + y*y <= 4*4 || x >= 0 && x <= 5 && y <= 0 && y >= -5 && x*x + y*y <= 5*5;
    cout <<  boolalpha << result << endl;
}