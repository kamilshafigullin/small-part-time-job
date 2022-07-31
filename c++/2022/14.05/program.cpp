// Реализовать программу-калькулятор с возможностью выполнения арифметических действий (+, -), унарный и бинарный вариант.
// У пользователя запрашивается выраже-ние, например, "-123,5 + 4 - 456+56",
// программа должна решить выражение. Для разбо-ра входной строки использовать функцию strok.

#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
 
void optimize(char str[16]) {
  /*for (int i = 0; i < 16; i++) {
     if (str[i] == '-') {
       str[i] = '+';
       i++;
     }
   }*/
  for (int i = 0; str[i] != '\0'; i++)
    if (isspace(str[i])) {
      for (int j = i; str[j] != '\0'; j++) str[j] = str[j + 1];
      i--;
    }
}
 
int main() {
  char str[16];
  char* istr;
  char sep[] = "+";
  int a, res = 0;
 
  gets(str);
  optimize(str);
 
  istr = strtok(str, sep);
  printf("%s\n", istr);
  while (istr != NULL) {
    printf("%s\n", istr);
    a = atoi(istr);
    res = res + a;
    istr = strtok(NULL, sep);
  }
  printf("%d", res);
  return 0;
}