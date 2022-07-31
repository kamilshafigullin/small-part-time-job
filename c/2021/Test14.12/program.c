#include <stdio.h>
#include <string.h>

#define N 30 //длина строки

int FindChar(char x, char* arr)
{
    //производим поиск заданного символа x по массиву arr
    for (int i = 0; arr[i] != '\0'; i++)
    {
        if (arr[i] == x)
        {
            //"удаляем" символ, если нашли такой в массиве
            memmove(arr+i, arr+i+1, strlen(arr) - i);
            arr[i] = arr[i + 1];
            return 1;
        }
    }
    //не нашли - возвращаем 0
    return 0;
}

int main()
{
    //объявляем строки
    char X[N];
    char Y[N];
    //ввод X
    printf("Введите X:\n");
    scanf("%s", &X);
    //ввод Y
    printf("Введите Y:\n");
    scanf("%s", &Y);

    //идём по каждому символу в Y
    for (int i = 0; Y[i] != '\0'; i++)
    {
        //передаём текущий символ в Y и массив X
        //если не нашли такой символ в массиве X - выводим НЕЛЬЗЯ и выходим из программы
        if (FindChar(Y[i], X) == 0)
        {
            printf("НЕЛЬЗЯ");
            return 0;
        }
    }

    //если ненайденных символов нет, значит можем составить строку Y из символов строки X
    printf("МОЖНО");
}