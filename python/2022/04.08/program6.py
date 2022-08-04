'''
Сформировать список из N членов последовательности
Для N = 5: 1, -3, 9, -27, 81 и т.д.
'''

print("Введите N: ", end = '')
N = int(input())

result = []
for i in range(N):
    n = pow(3, i)
    if (i % 2 > 0):
        n *= -1
    result.append(n)

print(', '.join(str(n) for n in result)) # выводим список, форматируя

# Результат работы программы при N = 4:
# 1, -3, 9, -27