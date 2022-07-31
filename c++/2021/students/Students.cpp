#include <stdlib.h>
#include <stdio.h>
#include <iostream>
 
#define MAX_LENGTH_NAME     32
#define NDISCIPLINES        5
#define PROGRESS_TRESHOLD   4
 
 
typedef struct student_tag {
    char name[MAX_LENGTH_NAME];
    int group;
    int marks[NDISCIPLINES];
    int scholarship;
} student_t;
 
//задаём количество вводимых студентов
#define NSTUDENTS 2
 
int main()
{ 
    setlocale (LC_ALL,"");
    int i;
    int j;
    float avg;
    student_t tmp;
    student_t students[NSTUDENTS];
    
    // ввод данных
    for(i = 0; i < NSTUDENTS; ++i) {
        printf("Введите фамилию и инициалы: ");
        gets(students[i].name);
        
        printf("Введите номер группы: ");
        if(scanf("%d", &students[i].group) != 1) {
            fprintf(stderr, "data reading error\n");
            return EXIT_FAILURE;
        }
        
        printf("Введите оценки:\n");
        for(j = 0; j < NDISCIPLINES; ++j) {
            if(scanf("%d", &students[i].marks[j]) != 1) {
                fprintf(stderr, "data reading error\n");
                return EXIT_FAILURE;
            }
        }
        
        printf("Введите стипендию: ");
        if(scanf("%d", &students[i].scholarship) != 1) {
            fprintf(stderr, "data reading error\n");
            return EXIT_FAILURE;
        }

        fflush(stdin);
    }
    
    // Сортировка
    for(i = 0; i < NSTUDENTS; ++i) {
        for(j = NSTUDENTS - 1; j >= i; --j) {
            if(students[j].group < students[j-1].group) {
                tmp = students[j];
                students[j] = students[j-1];
                students[j-1] = tmp;
            }
        }
    }
   
   //вывод студентов, имеющих только положительные оценки
    for(i = 0; i < NSTUDENTS; ++i) 
    {
      for(j = 0; j < NDISCIPLINES; ++j)
      {
            if(students[i].marks[j]>3)
            {
                printf("%s %d\n", students[i].name, students[i].scholarship);
                break;
             }
      }
    }  
    system ("pause");
}       