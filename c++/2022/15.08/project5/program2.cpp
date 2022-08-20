// В. Даны три квадратных матрицы А, В, С n-го порядка.
// Вывести на печать ту из них, норма которой наименьшая.
// Пояснение. Нормой матрицы назовем максимум из абсолютных величин ее элементов. 
#include <iostream>

using namespace std;

#define N 2

void print_arr(int arr[N][N])
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }
}

int main()
{
    int A[N][N] = {7, 3, 5, 45};
    int B[N][N] = {1, 99, 12, 4};
    int C[N][N] = {0, 6, 13, -5};

    int maxA = 1000;
    int maxB = 1000;
    int maxC = 1000;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            if(abs(A[i][j]) > maxA)
                maxA = A[i][j];
            if(abs(B[i][j]) > maxB)
                maxB = B[i][j];
            if(abs(C[i][j]) > maxC)
                maxC = C[i][j];     
        }
    }

    if (maxA > maxB && maxA > maxC)
        print_arr(A);
    else if (maxB > maxA && maxB > maxC)
        print_arr(B);
    else
        print_arr(C);
}