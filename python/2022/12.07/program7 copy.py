'''
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
Пример:
A (3, 6);   B(2, 1)  -> 5,09
A (7, -5);  B(1, -1) -> 7,21
'''

def DecToBin(number):
    result = ""
    while (True):
        result += str(number % 2)
        number = number // 2

        if (number == 1 or number == 0):
            result += str(number)
            break
    return result [::-1]

number = int(input("Десятичное число: "))
print(f"Число в двоичном виде: {DecToBin(number)}")