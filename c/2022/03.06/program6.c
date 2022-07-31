/*
* дан целочисленный массив С из n элементов.
* Найти среднее арифметической всех элементов массива 
* и подсчитать количество элементов больших среднео арифметического.
* 
*/
#include <stdio.h>
#include <stdlib.h>

void arifm(int* A, int n)
{
	int sum = 0, srednee = 0, count = 0;
	for (int i = 0; i < n; i++)
	{
		sum = sum + A[i];
	}
	srednee = sum /n;
	for (int i = 0; i < n; i++)
	{
		if (A[i] > srednee)
		{
			count++;
		}
	}
	printf("Среднее: %d\nКоличество: %d\n", srednee, count);
}

int main()
{
	int* C;
	int n;
	printf("input size array: ");
	scanf("%d",&n);
	C = (int*)malloc(sizeof(int) * n);
	for (int i = 0; i < n; i++) {
		C[i] = rand() % 12;
	}
	//вывод вектора после заполнения
	for (int i = 0; i < n; i++)
	{
		printf("%d\t", C[i]);
	}
	printf("\n");
	arifm(C, n);
	return 0;
}