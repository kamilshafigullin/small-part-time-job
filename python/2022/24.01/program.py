print("Введите 3 числа")
# ввод строки
nums = [int(a) for a in input().split()]
for i in range(0, 2):
    if nums[i] != nums[i + 1]:
        print("Числа не одинаковы")
        exit(0)

print("Все три числа одинаковые")