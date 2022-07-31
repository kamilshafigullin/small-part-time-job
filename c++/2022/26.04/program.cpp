#include<iostream>
#include <fstream>
using namespace std;

#define arr_i 2
#define arr_j 3

int main(int argc, char *argv[])
{
    float arr[arr_i][arr_j] = {1.5, 2.3, 4.5, 6.3, 1.9, 9.1};

    ofstream fout("file.txt"); // создаём объект класса ofstream для записи и связываем его с файлом file.txt
    for (int j = 0; j < arr_j; j++)
    {
        fout << arr[arr_i - 1][j] << " "; // запись элементов последней строки массива через пробел
    }
    fout << "\n";
    for (int i = 0; i < arr_i; i++)
    {
        fout << arr[i][0] << " "; // запись элементов первого столбца массива через пробел
    }
    fout << "\n";
    fout << "Символьная строка";

    fout.close(); // закрываем файл
    return 0;
}