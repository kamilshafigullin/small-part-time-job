#include <stdio.h>

#define N 5

int main()
{

    // инициализируем два массива
    int d[N] = {1, 2, 3, 4, 5};
    int w[N] = {10, 5, 3, 20, 7};

    //вычисляем, сколько метров разрезать будет выгоднее всего
    float max = -1;
    int dMax = -1;
    for (int i = 0; i < N; i++)
    {
        if (w[i] / d[i] > max)
        {
            max = w[i] / d[i];
            dMax = i;
        }
    }

    //вывод
    printf("Выгоднее всего разрезать провод на %d м (%.1f р за метр)", d[dMax], max);
}

// результат для текущего примера:
// Выгоднее всего разрезать провод на 1 м (10.0 р за метр)