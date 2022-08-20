// Дана целая квадратная матрица п-го порядка.
// Определить, является ли она магическим квадратом,
// т.е. такой, в которой суммы элементов во всех строках и столбцах одинаковы. 
#include <iostream>

using namespace std;

int main()
{
    int n;
    int** matrix;
    int* rows_sum;
    int* cols_sum;
    cout << "Введите n (порядок): ";
    cin >> n;

    rows_sum = new int[n] {0};
    cols_sum = new int[n] {0};

    matrix = new int*[n];
    for (int i = 0; i < n; i++) 
        matrix[i] = new int[n];
    
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cout << "Введите элемент с индексом " << i << " " << j << endl;
            cin >> matrix[i][j];
            rows_sum[i] += matrix[i][j];
            cols_sum[j] += matrix[i][j];
        }
    }

    for (int i = 0; i < n - 1; i++)
    {
        if (rows_sum[i] != rows_sum[i+1] || cols_sum[i] != cols_sum[i+1])
        {
            cout << "Не является магическим квадратом" << endl;
            return 0;
        }
    }

    cout << "Является магическим квадратом" << endl;
    return 0;
}