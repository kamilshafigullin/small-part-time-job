# Дана квадратная матрица. Произвести транспонирование (переворот) матрицы
# относительно ее главной диагонали. Сформировать новый одномерный
# массив, в который записать элементы четных строк полученной матрицы в
# последовательности сверху вниз и слева направо.

from random import randint

N = 3
a = [[0] * N for i in range(N)]
for i in range(0, N):
    for j in range(0, N):
        a[i][j] = randint(1, 10)
        print(a[i][j], end = " ")
    print()

# Транспонирование
a_trans = [[0] * N for i in range(N)]
for i in range(0, N):
    for j in range(0, N):
        a_trans[j][i] = a[i][j]

print("Транспонированная матрица:")
for i in range(0, N):
    for j in range(0, N):
        print(a_trans[i][j], end = " ")
    print()

result = []

for i in range(0, N, 2):
    for j in range(0, N):
        result.append(a_trans[i][j])

print("Результат:")
print(result)

