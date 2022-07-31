/*
* В матрице A(N*N) и в массиве B(M) заменить все числа, 
* кратные 3, единицами
*/

#include<stdio.h>
#include<stdlib.h>

int main() {
	int A[10][10];
	int B[9];
	//заполняем массивы рандомными числами
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			A[i][j] = rand() % 56;
		}
	}
	for (int i = 0; i < 9; i++)
	{
		B[i] = rand() % 71;
	}
	

	//заменяем элементы массивы кратные 3 единицами
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			if (A[i][j] % 3 == 0)
			{
				A[i][j] = 1;
			}
		}
	}
	for (int i = 0; i < 9; i++)
	{
		if (B[i] % 3 == 0) {
			B[i] = 1;
		}
	}
	//выведем массивы
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			printf("%d--", A[i][j]);
		}
		printf("\n");printf("\n");
	}
	printf("\n");
	for (int i = 0; i < 9; i++)
	{
		printf("%d--", B[i]);
	}
	

	return 0 ;
}