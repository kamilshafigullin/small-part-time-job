/*
определить количество элементов массива A[50], отличающихся 
от своих соседей слева как минимум вдвое
*/
#include <stdio.h>
#include <stdlib.h>

#define N 50

int main()
{
	int A[50];
	// заполняем его рандомными числами 
	for (int i = 0; i < N; i++)
	{
		A[i] = rand() % 123;
	}

	printf("Массив:\n");
	for (int i = 0; i < N; i++)
	{
		printf("%d ", A[i]);
	}

	//подсчет количества элементов удовлетворяющих условию задачи
	int count = 0;
	for (int i = 1; i < N; i++)
	{
		if (A[i] / A[i-1] >= 2)
		{
			count++;
		}
	}
	printf("\nРезультат: %d\n", count);
	return 0;
}