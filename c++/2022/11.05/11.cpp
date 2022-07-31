// Создать в отдельном модуле функции с переменным количеством аргументов,
// которая вычисляет их сумму, максимум, минимум, среднее арифметическое.

#include<iostream>
#include "module.h"

using namespace std;

int main()
{
    doWork(5, 11);
    cout << endl;
    doWork2(6, 4, 10);
}