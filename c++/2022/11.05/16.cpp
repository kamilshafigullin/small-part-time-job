	// Написать программу подсчитывающая количество битов,
  // выставленных в еди-ницу у числа типа long и double. Сами значения чисел вводятся с клавиатуры.    

#include <stdio.h>
#include <stdlib.h>
 
int num_bits(int n)
{
    if (n == 0) return 0;
    return (n%2)+num_bits(n/2);
}

int main(int argc, char *argv[])
{
  int n;
  printf("n:");
  scanf("%d", &n);
  printf("Количество битов = %d\n", num_bits(n)); 
  system("PAUSE");
  return 0;
}