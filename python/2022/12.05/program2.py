# Вводится натуральное число N. С помощью list comprehension сформировать
# двумерный список размером N x N, состоящий из единиц, а побочная
# диагональ – нулей. Результат вывести на экран.

N = int(input())

lst = [[int(y==i) for y in range(N)] for i in range(N)]

for stroke in lst:
    print(stroke)

