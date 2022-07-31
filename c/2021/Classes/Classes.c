#include <stdio.h>
#include <conio.h>
#include <string.h>
 
int main()
{
    //структура сведения об ученике
    struct rec
    {
        char name[15], fam[15],
             kl[15], god[15];
    };
    
    //массив структур
    struct rec array[100];

    FILE *f;
    int i, c = 0, j;
    
    //открываем файл f только для чтения
    f = fopen("classesInfo.txt","r");
    //записываем построчно в массив сведения об одном ученике
    while (! feof(f))
    {
        fscanf(f,"%s",array[c].fam);
        fscanf(f,"%s",array[c].name);
        fscanf(f,"%s",array[c].kl);
        fscanf(f,"%s",array[c].god);
        c++;
    }
    //закрываем файл
    fclose(f);

    //пробегаемся по массиву, сравнивая все пары
    //и печатаем однофамильцев, если такие есть
    printf("Однофамильцы:\n");
    for (i=0; i<=c; i++)
    for (j=i+1; j<c; j++)
    if (strcmp(array[i].fam, array[j].fam) == 0 && strcmp(array[i].name, array[j].name) == 0)
        printf("%s %s %s %s - %s %s %s %s\n",array[i].fam, array[i].name, array[i].kl, array[i].god,
                                             array[j].fam, array[j].name, array[j].kl, array[j].god);
  getch();
}