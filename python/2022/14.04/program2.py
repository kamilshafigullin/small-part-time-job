
print('Введите n (количество элементов):')
n = int(input())

x = 7
sum = 0
# 7, 14, 21, 28...
for i in range (0, n):
    sum = sum + x
    x  = x + 7

print('Результат: ' + str(sum)) 