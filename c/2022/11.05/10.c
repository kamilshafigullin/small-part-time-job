// Написать программу вычисления максимального числа из введенных пользова-телем в виде одной строки.
// Использовать для этого макрос (без функции), на вход которому подается массив чисел и их количество.

#include <stdio.h>

#define N 100

#define MAX(arr, n) FindMax(arr, n);

int arr[N] = { 0 };

void FindMax(int* arr, int n)
{
    int max = arr[0];
    for (int i = 0; i < N; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }

    printf("Максимум: %d", max);
}

int* convertStrToArr(char* str)
{
    int j = 0;
    int i;
    int max = 0;
    for (i = 0; str[i] != '\0'; i++)
    {
        if (str[i] == ',')
            continue;
        if (str[i] == ' ')
            j++;
        else
        {
            arr[j] = arr[j] * 10 + (str[i] - 48);
            if (arr[j] > max)
                max = arr[j];
        }
    }

    return arr;
}

int main()
{
    char str[N];
    gets(str);
    int* arr = convertStrToArr(str);
    MAX(arr, N);
  
    return 0;
}