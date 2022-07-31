// 9.	Найти среднее арифметическое значение элементов массива, расположенных между минимальным и максимальным элементами массива.
#include <iostream>

using namespace std;

int main()
{
    int a[20];

    int max = 0;
    int maxIndex;

    int min = 10;
    int minIndex;
    //заполнение массива и поиск индексов мин. и макс. элементов массива
    for (int i = 0; i < 20; i++)
    {
        //случайное число из диапазона [1;9]
        a[i] = rand() % 29 + 1;
        cout << a[i] << " ";
        if (a[i] > max)
        {
            max = a[i];
            maxIndex = i;
        }
        if (a[i] < min)
        {
            min = a[i];
            minIndex = i;
        }
    }
    //вычисляем какой индекс меньше, т.к. идём по возрастанию
    int from;
    int to;
    if (maxIndex < minIndex)
    {
        from = maxIndex;
        to = minIndex;
    }
    else
    {
        from = minIndex;
        to = maxIndex;
    }
    float sr = 0;
    //ищем среднее арифметическое между элементами
    for (int i = from + 1; i < to; i++)
    {
        sr += a[i];
    }

    sr = sr / (to - from - 1);
    cout << "\nИндекс минимального элемента: " << minIndex << endl;
    cout << "Индекс максимального элемента: " << maxIndex << endl;
    cout << "Результат работы программы (cреднее арифм.): " << sr << endl;
}