from math import *

print('Введите a (высота пирамиды):')
a = int(input())

print('Введите φ в градусах от 1 до 89 (угол между плоскостью основания и боковыми гранями):')
angle = int(input())
# переводим в радианы
angle = (angle * pi) / 180
# вычисляем высоты
height = a/sin(angle)
print('Высоты боковых граней: ' + str(height))