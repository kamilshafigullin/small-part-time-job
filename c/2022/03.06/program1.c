//* элементы, лежащие на главной и побочной диагоналях матрицы
//М(7*7), заменить их квадратами. */

#include <stdio.h>
#include <stdlib.h>

int main() {
	int M[7][7];
	for (int i = 0; i < 7; i++) {
		for (int j = 0; j < 7; j++) {
			M[i][j] = rand() % 10;
     }
	}

	for (int i = 0; i < 7; i++) {
		for (int j = 0; j < 7; j++) {
			if (i == j) {
				int kv = M[i][j] * M[i][j];
				M[i][j] = kv;
			}
		}
	}
	return 0;
}