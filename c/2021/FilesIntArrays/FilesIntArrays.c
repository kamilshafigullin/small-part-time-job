#include <stdio.h>
#define LEN 10 //размер массивов

int main()
{
    //инициализируем массивы
    int positiveInts[LEN]; //массив положительных чисел из файла
    int negativeInts[LEN]; //массив отрицательных чисел из файла

    int i = 0; //счётчик

    //открываем файл f.txt с модификатором r - только для чтения
    FILE *f;
    f = fopen("f.txt", "r");

    //читаем положительные числа из файла f
    for (i = 0; i < LEN; i++)
    {
        fscanf(f, "%d,", &positiveInts[i]);
    }
    //читаем отрицательные числа из файла f
    for (i = 0; i < LEN; i++)
    {
        fscanf(f, "%d,", &negativeInts[i] );
    }
    //закрываем файл
    fclose(f);

    //создаем файл g.txt c модификатором wb+ - для записи и чтения
    //с опцией удаления содержимого и перезаписывания файла
    FILE *g = NULL;
    g = fopen("g.txt", "wb+");

    //записываем в g.txt
    for (i = 0; i < LEN; i++)
    {
        //записываем дважды текущий элемент
        for (int n = 0; n < 2; n++)
            fprintf(g,"%d ",positiveInts[i]);
    }
    for (i = 0; i < LEN; i++)
    {
        for (int n = 0; n < 2; n++)
            fprintf(g,"%d ",negativeInts[i]);
    }
    fclose(g);
    return 0;
}
/*
пример файла f.txt:
    1 2 3 4 5 6 7 8 9 10 -1 -2 -3 -4 -5 -6 -7 -8 -9 -10
выходной файл g.txt:
    1 1 2 2 3 3 4 4 5 5 6 6 7 7 8 8 9 9 10 10 -1 -1 -2 -2 -3 -3 -4 -4 -5 -5 -6 -6 -7 -7 -8 -8 -9 -9 -10 -10
*/