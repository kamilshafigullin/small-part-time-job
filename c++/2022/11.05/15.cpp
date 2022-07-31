// Дано натуральное число N. Выведите все его цифры по одной, в обычном порядке (а потом в обратном),
// разделяя их пробелами или новыми строками. Например: 179 => 1 7 9; 179 => 9 7 1
// При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется).

#include <iostream>

void print_reverse(int n)
{
    if (n == 0)
        return;
    
    printf("%d ", n % 10);
    print_reverse(n / 10);
}
 
int main()
{
    int n = 179;
    int n_temp = n;
    int reversed_n = 0;
    while(n_temp != 0)
    {
        reversed_n = reversed_n * 10 + n_temp % 10;
        n_temp /= 10;
    }
    print_reverse(reversed_n);
    printf("\n");
    print_reverse(n);
}