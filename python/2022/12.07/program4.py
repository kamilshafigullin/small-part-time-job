'''
Реализуйте выдачу случайного числа
не использовать библиотеку random
Можете использовать xor, биты, библиотеку time (миллисекунды или наносекунды)
'''

from time import time

def time_random():
 return time() - float(str(time()).split('.')[0])

def gen_random_number():
 return int(time_random() * 100)

print(f"Случайное число: {gen_random_number()}")