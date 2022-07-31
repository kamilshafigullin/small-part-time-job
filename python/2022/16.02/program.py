
a = int(input())
sum = 0
while (a != 0):
    sum = sum + a % 10
    a = a / 10

if (sum > 15):
    print("сумма больше 15")
else:
    print("сумма меньше 15")