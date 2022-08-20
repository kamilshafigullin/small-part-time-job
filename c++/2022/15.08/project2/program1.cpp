// А. На плоскости ХОY задана своими координатами точка А. Указать, где она расположена (на какой оси или в каком координатном угле).
#include <iostream>

using namespace std;

int main()
{
    float x, y;
    cout << "Введите x: ";
    cin >> x;
    cout << "Введите y: ";
    cin >> y;

    if (x == 0 && y == 0)
        cout << "В начале координат" << endl;
    else if (x == 0 && y != 0)
        cout << "На оси Y" << endl;
    else if (x != 0 && y == 0)
        cout << "На оси X" << endl;
    else if (x > 0 && y > 0)
        cout << "I четверть" << endl;
    else if (x < 0 && y > 0)
        cout << "II четверть" << endl;
    else if (x < 0 && y < 0)
        cout << "III четверть" << endl;
    else
        cout << "IV четверть" << endl;
}