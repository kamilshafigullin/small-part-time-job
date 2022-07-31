from mailcap import findmatch
from tracemalloc import start

field = []

def FindMaxLeft(field, startIndex) -> int:
    result = 0
    startIndex = startIndex - 1
    while (startIndex >= 0 and field[startIndex] != 0 and field[startIndex] != 1):
        result = result + 1
        field[startIndex] = 1
        startIndex = startIndex - 1
    return result

def FindMaxRight(field, startIndex) -> int:
    result = 0
    startIndex = startIndex + 1
    while (startIndex < len(field) and field[startIndex] != 0 and field[startIndex] != 1):
        result = result + 1
        field[startIndex] = 1
        startIndex = startIndex + 1
    return result

def FindMax(field, maxLength) -> int:
    result = 0
    i = 0
    while (i != int(maxLength)):
        if (field[i] == 0):
            result = result + FindMaxLeft(field, i)
        if (field[i] == 1):
            result = result + FindMaxRight(field, i)
        i = i + 1
    return result


countLenght = input().split(' ')

field = [-1] * int(countLenght[1])
for i in range (0, int(countLenght[0])):
    fishka = input().split(' ')
    field[int(fishka[0]) - 1] = int(fishka[1])

print(FindMax(field, int(countLenght[1])))