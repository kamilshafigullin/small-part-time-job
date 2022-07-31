'''
Задайте список из n чисел последовательности (1+1/n)**n
и выведите на экран и сумму
Пример:
Для n = 6: {1: 2.0, 2: 2.25, 3: 2.37037037037037, ..., 6: 2.5216263717421135}
'''

print("Введите n:")
N = int(input())

for i in range(1, N + 1):
    result = (1 + 1 / i)**i
    print(f"{i} :{result}")