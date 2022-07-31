# Среди натуральных чисел, которые были введены с клавиатуры, найти
# наибольшее по сумме цифр. Вывести на экран это число и сумму его цифр.

def get_digits_sum(num)->int:
    sum = 0
    for digit in num:
        sum += int(digit)
    return sum


nums = input().split(' ')

result_num = 0
max_sum = 0
for num in nums:
    cur_sum = get_digits_sum(num)
    if (cur_sum > max_sum):
        max_sum = cur_sum
        result_num = num

print(f"Число: {result_num}, его сумма цифр: {max_sum}")