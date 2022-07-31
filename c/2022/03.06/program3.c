/*
* Даны 2 массива A(N) И B(N).
* В массиве с большей суммой элементов найти минимум 
* и удалить его . Для получения суммы элементов в массиве и 
* нахождения минимум и его удаления использовать функции
*/
#include <stdio.h>
#include <stdlib.h>

#define N 10

int is_first_array = 0;

void print(int* L, int count)
{
	for (int i = 0; i < count; i++)
	{
		printf("%d\t", L[i]);
	}
	printf("\n");
}

// заполнения векторов случайнми числами
void Vd(int V[N], int k)
{
	for (int i = 0; i < N;i++)
	{
		V[i] = rand() % k;
	}	
};

// функция которая сравнивает по сумме два вектора, далее находит минимум и удаляет уго путем перестановки
void daf(int V[N], int C[N])
{
	int sum1 = 0; int sum2 = 0;
	//сумма элементов первого массива
	for (int i = 0; i < N; i++)
	{
		sum1 += V[i];
	}
	//сумма элементов второго массива
	for (int i = 0; i < N; i++)
	{
		sum1 += C[i];
	}
	if (sum1 > sum2)
	{
		int index = 0;
		int min = V[0];
		for (int i = 0; i < N; i++)
		{
			if (V[i] < min) {
				min = V[i];
				index = i;
			}
		}
		// переставляю элемент в конец строки и удаляю его
		int t = V[N - 1];
		V[N - 1] = V[index];
		V[index] = t;
		is_first_array = 1;
	}
	else
	{
		int index = 0;
		int min = C[0];
		for (int i = 0; i < N; i++)
		{
			if (C[i] < min) {
				min = C[i];
				index = i;
			}
		}
		// переставляю элемент в конец строки и удаляю его
		int t = C[N-1];
		C[N-1] = C[index];
		C[index] = t;
		is_first_array = 0;
	}
}

int main()
{
	int A[N];
	int B[N];
	Vd(A, 10); // первым аргументом вектор, а вторым параметр для rand()
	Vd(B, 13);

	printf("A: ");
	print(A, N);
	printf("B: ");
	print(B, N);

	daf(A, B);

	// переменная определяет в каком массиве произвелось "удаление"
	// если в первом - не выводим последний элемент
	if (is_first_array == 1)
	{
		printf("A: ");
		print(A, N-1);
		printf("B: ");
		print(B, N);
	}
	else
	{
		printf("A: ");
		print(A, N);
		printf("B: ");
		print(B, N-1);
	}

	return 0;
}