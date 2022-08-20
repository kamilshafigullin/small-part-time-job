// Сформировать квадратную матрицу порядка n по заданному образцу...
#include <iostream>

using namespace std;

int main()
{
    int n;
    int** matrix;
    cout << "Введите n (порядок): ";
    cin >> n;

    matrix = new int*[n];
    for (int i = 0; i < n; i++) 
        matrix[i] = new int[n];
    
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                matrix[i][j] = 1;
            else
                matrix[i][j] = 0;
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cout << matrix[i][j] << " ";
        }
        cout << endl;
    }
}