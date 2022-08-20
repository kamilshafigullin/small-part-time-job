// В. Даны четыре точки А1(х1, у1), А2(x2 ,у2), А3(x3 , у3), А4(х4, у4). Определить, будут ли они вершинами параллелограмма

#include <iostream>
#include <cmath>

using namespace std;

// Определим функцию для проверки косинуса угла
float cos_angle(float x1, float y1, float x2, float y2, float x3, float y3)
{
    float a = (x1 - x2) * (x1 - x3) + (y1 - y2) * (y1 - y3);
    float b = sqrt(pow((x1 - x2), 2) + pow((y1 - y2),2));
    float c = sqrt(pow((x1 - x3), 2) + pow((y1 - y3),2));
    return a / (b * c);
}

// Функция проверяет является ли четырехугольник параллелограммом
bool is_paral(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
{
    float cos_a1 = cos_angle(x1, y1, x2, y2, x4, y4);
    float cos_a2 = cos_angle(x2, y2, x3, y3, x1, y1);
    float cos_a3 = cos_angle(x3, y3, x4, y4, x2, y2);
    float cos_a4 = cos_angle(x4, y4, x3, y3, x1, y1);
    // проверяем равенство углов и сумму соседних углов,
    // т.е. проверяем свойства параллелограма
    if (cos_a1 == cos_a3 && cos_a2 == cos_a4 && (cos_a1 + cos_a2) == 0.0 && (cos_a3 + cos_a4) == 0.0)
        return true;
    else
        return false;
}

int main()
{
    float x1, y1, x2, y2, x3, y3, x4, y4;
    cout << "Введите x1: ";
    cin >> x1;
    cout << "Введите y1: ";
    cin >> y1;

    cout << "Введите x2: ";
    cin >> x2;
    cout << "Введите y2: ";
    cin >> y2;

    cout << "Введите x3: ";
    cin >> x3;
    cout << "Введите y3: ";
    cin >> y3;

    cout << "Введите x4: ";
    cin >> x4;
    cout << "Введите y4: ";
    cin >> y4;

    if (is_paral(x1,y1,x2,y2,x3,y3,x4,y4))
        cout << "Является" << endl;
    else
        cout << "Не является" << endl;
}