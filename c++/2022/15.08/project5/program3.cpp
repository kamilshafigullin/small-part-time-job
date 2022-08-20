// Решить следующие задачи, используя рекурсивную подпрограмму. 
// Описать функцию min(X) для определения минимального элемента линейного массива X,
// введя вспомогательную рекурсивную функцию minl(k), находящую минимум среди последних элементов массива X, начиная с k-го.
#include <iostream>
 
int minl(int X[], const int &n, int k)
{
    if (k == n - 1)
        return X[n-1];
    return std::min(minl(X, n, k+1), X[k]);
}

int Min(int X[], const int &n)
{
    return minl( X, n, 0 );
}

int main()
{
    int arr[] = { -2, -8, -7, 5, -4, 9 };
    const int n = sizeof(arr) / sizeof(arr[0]);
    std::cout << Min(arr, n);
    return 0;
}