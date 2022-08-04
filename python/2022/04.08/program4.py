'''
Определить позицию второго вхождения строки в списке
либо сообщить, что её нет.
'''

seq = ["123", "234", 123, "567"]
query = "123"

find_count = 0
for i in range(len(seq)):
    if isinstance(seq[i], str) and query in seq[i]:
        find_count += 1
        if (find_count == 2): # если это второе вхождение
            print(i)
            exit()

print(-1)

# Результат работы программы при исходных 'seq' и 'query': -1