#include <stdio.h>

#define N 10

int fun(int array[N]) // возвращает количество чётных элементов
{
    int result = 0;

    for (int i = 0; i < N; i++)
    {
        if (array[i] % 2 == 0)
            result += 1;
    }

    return result;
}

int main()
{
    int array[N] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

    int result = fun(array);

    printf("Количество чётных элементов массива array: %d", result);

    return 0;
}