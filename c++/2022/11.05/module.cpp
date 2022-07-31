#include <iostream>

using namespace std;

int doWork(int a, int b)
{
    int max, min, sum;
    float average;
    if (a > b)
    {
        max = a;
        min = b;
    }
    else
    {
        max = b;
        min = a;
    }

    sum = a + b;
    average = (float)sum / 2;

    cout << "Максимум: " << max << endl;
    cout << "Минимум: " << min << endl;
    cout << "Сумма: " << sum << endl;
    cout << "Ср. арифметическое: " << average << endl;
}

int doWork2(int a, int b, int c)
{
    int max, min, sum;
    float average;
    
    if (a >= b && a >= c)
    {
        max = a;
    }
    else if (b >= a && b >= c)
    {
        max = b;
    }
    else
    {
        max = c;
    }

    if (a <= b && a <= c)
    {
        min = a;
    }
    else if (b <= a && b <= c)
    {
        min = b;
    }
    else
    {
        min = c;
    }

    sum = a + b + c;
    average = (float)sum / 3;

    cout << "Максимум: " << max << endl;
    cout << "Минимум: " << min << endl;
    cout << "Сумма: " << sum << endl;
    cout << "Ср. арифметическое: " << average << endl;
}