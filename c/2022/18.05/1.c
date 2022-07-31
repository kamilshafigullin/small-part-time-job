#include<stdio.h>
#include<string.h> // для strncmp

// собственная реализация функции strncmp
int my_strncmp(const char * s1, const char * s2, size_t n)
{
    while (n && *s1 && ( *s1 == *s2 )) // идём по циклу пока сравниваемые символы равны
    {
        ++s1;
        ++s2;
        --n;
    }
    if (n == 0) // если идентичны (дошли до первого символа строк)
    {
        return 0;
    }
    else // иначе возвращаем разницу
    {
        return (*(unsigned char *)s1 - *(unsigned char *)s2);
    }
}

int main()
{
    char str1[16]="12345674";
    char str2[16]="12345039";

    printf("Проверка стандартной функции:\n");
    printf("Сравниваемые строки (по первым 4-м символам): %s и %s\n", str1, str2);
    if (strncmp(str1, str2, 4) == 0)
    {
        printf("Первые 4 символа идентичны\n");
    }
    else
    {
        printf("Первые 4 символа не идентичны\n");
    }

    printf("Проверка собственной функции:\n");
    printf("Сравниваемые строки (по первым 4-м символам): %s и %s\n", str1, str2);
    if (my_strncmp(str1, str2, 4) == 0)
    {
        printf("Первые 4 символа идентичны\n");
    }
    else
    {
        printf("Первые 4 символа не идентичны\n");
    }

    return 0;
}