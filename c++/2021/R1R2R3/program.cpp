#include <iostream>
#include <fstream>
#include <cmath>

using namespace std;

int main()
{
    setlocale (LC_ALL, "rus");

    //максимальное обрабатываемое количество строк в файле
    const int SIZE = 100;
    //определяем массив структур
    struct Point
    {
        int R1;
        int R2;
        int R3;
    }points[SIZE];

    //ввод 'E'
    int E;
    cout << "Введите значение расстояния E: ";
    cin >> E;

    ifstream myfile("example.txt");
    //выход при ошибке открытии файла
    if (!myfile)
    {
        cerr << "Файл не может быть открыт" << endl;
        exit(1);
    }

    /* кол-во точек, удаления которых
    от каждой из трёх заданных превышает
    расстояние E */
    int truePointsCount = 0;
    //произведение ср. геометрического соотв. ей значений
    float res = 1;
    //индексатор
    int i = 0;
    //читаем файл построчно
    while (myfile >> points[i].R1 >> points[i].R2 >> points[i].R3 && i < SIZE)
    {
        //проверяем, все ли точки превышают значение 'E'
        if (points[i].R1 > E && points[i].R2 > E && points[i].R3 > E)
        {
            truePointsCount += 1;
            //произведение
            float multi = points[i].R1 * points[i].R2 * points[i].R3;
            //заводим его в корень 3-й степени (1/3)
            res = pow(multi, 1.0/3);
            cout << "Среднее геометрическое для строки №" << (i + 1) << ": " << res << endl;
        }
        i += 1;
    }

    //находим процент точек
    float percentage = (float)truePointsCount / (float)i;
    cout << "Процент точек: " << percentage << endl;

    //закрываем файл
    myfile.close();
    return 0;
}