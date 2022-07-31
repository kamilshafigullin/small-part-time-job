#include <stdio.h>

void doWork(int a, int b)
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

    printf("Максимум: %d\n", max);
    printf("Максимум: %d\n", min);
    printf("Сумма: %d\n", sum);
    printf("Ср. арифметическое: %.2f\n", average);
}

void doWork2(int a, int b, int c)
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

    printf("Максимум: %d\n", max);
    printf("Максимум: %d\n", min);
    printf("Сумма: %d\n", sum);
    printf("Ср. арифметическое: %.2f\n", average);
}