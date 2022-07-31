// 9.	Известна температура каждого дня апреля. Определить среднюю температуру апреля по декадам и указать самую теплую из них.
#include <iostream>

using namespace std;

int main()
{
    int a[30];
    for (int i = 0; i < 30; i++)
    {
        a[i] = rand() % 30;
        cout << i + 1 << "-й день" << ": " << a[i] << " градусов" << endl;
    }
    //первая декада
    int sum1 = 0;
    for (int i = 0; i < 10; i++)
        sum1 += a[i];
    sum1 = sum1 / 10;
    cout << "Ср. температура в первой декаде: " << sum1 << endl;
    //вторая декада
    int sum2 = 0;
    for (int i = 10; i < 20; i++)
        sum2 += a[i];
    sum2 = sum2 / 10;
    cout << "Ср. температура во второй декаде: " << sum2 << endl;
    //первая декада
    int sum3 = 0;
    for (int i = 20; i < 30; i++)
        sum3 += a[i];
    sum3 = sum3 / 10;
    cout << "Ср. температура в третьей декаде: " << sum3 << endl;

    int sumMax;
    if (sum1 > sum2)
        sumMax = sum1;
    else
        sumMax = sum2;
    if (sum3 > sumMax)
        sumMax = sum3;
    cout << "Значение самой тёплой декады: " << sumMax << endl;
}