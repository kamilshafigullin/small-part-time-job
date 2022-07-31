
def longestRun(arr):
    longestUpMax = 1
    longestDownMax = 1
    # обновляемые переменные
    longestDown = 1
    longestUp = 1

    lenght = len(arr)
    for i in range(1, lenght):
        if (arr[i] - 1 == arr[i-1]):
            longestUp += 1
        elif (longestUp > longestUpMax):
            longestUpMax = longestUp
            longestUp = 1
        if (arr[i] + 1 == arr[i-1]):
            longestDown += 1
        elif (longestDown > longestDownMax):
            longestDownMax = longestDown
            longestDown = 1
    
    # учитываем последний проход 
    if (longestDown > longestDownMax):
        longestDownMax = longestDown
    if (longestUp > longestUpMax):
        longestUpMax = longestUp

    if (longestDownMax > longestUpMax):
        return longestDownMax
    else:
        return longestUpMax

# arr = [7,6,3,2,1]
# print(longestRun(arr))
# вывод: 3