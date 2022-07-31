# Саша и Галя коллекционируют монетки. Каждый из них решил записать
# номиналы монеток из своей коллекции. Получилось два списка. Эти списки
# поступают на вход программы в виде двух строк из целых чисел, (числа
# записаны через пробел). Необходимо выделить значения, присутствующие
# только в одном списке и оставить среди них только нечетные. Результат
# вывести на экран.
# При реализации программы используйте функцию filter и кое-что еще (для
# упрощения программы), подумайте что.

lst1 = input().split(' ')
lst2 = input().split(' ')

# для фильтрации первого списка
def filter_lst1(num) -> list:
    compare_list = lst2

    has_num = True
    for i in compare_list:
        if (i == num):
            has_num = False
    
    if has_num == True and int(num) % 2 == 1:
        return num

# для фильтрации второго списка
def filter_lst2(num) -> list:
    compare_list = lst1

    has_num = True
    for i in compare_list:
        if (i == num):
            has_num = False
    
    if has_num == True and int(num) % 2 == 1:
        return num

result_lst = list(filter(filter_lst1, lst1)) # содержит числа из первого списка
result_lst2 = list(filter(filter_lst2, lst2)) # содержит числа из второго списка

result_lst.extend(result_lst2) # объединяем два списка
print(result_lst)

