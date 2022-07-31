import random

list1 = []
list2 = []

for i in range(5):
    list1.append(random.randint(1, 10))
    list2.append(random.randint(1, 10))

# вывод списков
print("Первый список")
print(list1)
print("Второй список")
print(list2)

count = 0
for i in range(5):
    # если i-й элемент второго списка содержится в первом списке
    if list2[i] in list1: 
        count = count + 1

print("Количество совпадающих чисел: %d" % count)