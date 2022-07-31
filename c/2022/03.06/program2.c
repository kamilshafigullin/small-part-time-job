/* Дана матрица В размером 5*5. В строке матрицы
с минимальной суммой элементов найти максимальный элемент */

#include <stdio.h>
#include <stdlib.h>

int main()
{
	int B[5][5];
	for (int i = 0; i < 5; i++) {
		for (int j = 0; j < 5; j++) {
			B[i][j] = rand() % 100;
		}
	}
	for (int i = 0; i < 5; i++) {
		for (int j = 0; j < 5; j++) {
			printf("%d\t", B[i][j]);
		}
		printf("\n");
	}
	int sumMin = 0;	// первоначальная минимальная сумма строки это сумма элеменетов первой строки
	int n = 0;	// индекс строки
	for (int j = 0; j < 5; j++) {
		sumMin = sumMin + B[0][j];
	}
	for (int i = 0; i < 5; i++) {
		for (int j = 0; j < 5; j++) {
			int sum = 0;
			sum = sum + B[i][j];
			if (sum < sumMin) {
				sumMin = sum;
				n = i;
			}
		}
	}
	// теперь найдем максимальный элемент
	int max = 0; // максимальный элемент
	for (int j = 0; j < 5; j++) {
		if (B[n][j] > max) {
			max = B[n][j];
		}
	}
	printf("MAX ELEMENT: %d", max);
	return 0;
}