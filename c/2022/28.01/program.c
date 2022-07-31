#include <stdio.h>
#include <string.h>

int main()
{
    printf("Введите текст:");
    char str[10];
    gets_s(str, 10);
    printf("%s", str);
}