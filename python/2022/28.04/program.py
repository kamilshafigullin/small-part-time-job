

sum = 0
n = 0
while (True):
    number = int(input())
    if (number == 0): # встретили 0 - выходим из цикла
        break
    else:
        sum += number # считаем сумму
        n += 1 # подсчёт количества

print(sum / n)