import math
from io import TextIOWrapper

# сортировка вставками
def sort_insertion(a: list, is_desc: bool)->list:
    for i in range(1, len(a)):
        for j in range(i, 0, -1):
            if (a[j-1] < a[j] and is_desc):
                a[j-1], a[j] = a[j], a[j-1]
            elif (a[j-1] > a[j] and is_desc == False):
                a[j-1], a[j] = a[j], a[j-1]
            else:
                break

# сортировка пузырьком
def sort_bubble(a: list, is_desc: bool)->list:
    for i in range(0, len(a) - 1):
        for j in range(0, len(a)-i-1):
            if (a[j] < a[j+1] and is_desc):
                a[j+1], a[j] = a[j], a[j+1]
            elif (a[j] > a[j+1] and is_desc == False):
                a[j+1], a[j] = a[j], a[j+1]
            else:
                break

# вычисление среднего арифметического значения набора данных
def get_list_average(nums: list)->float:
    sum = 0
    for num in nums:
        sum += num
    return sum / len(nums)

# вычисление среднего квадратического значения набора данных
def get_list_average_square(nums: list)->float:
    sum = 0
    for num in nums:
        sum += num * num
    return math.sqrt(sum / len(nums))

# функция записи в файл (добавляет символ перевода строки к каждой введённой записи, если параметр add_nl = True [по умолчанию])
def file_write_line(f: TextIOWrapper, data: str, add_nl=True):
    if (add_nl):
        f.write(data + '\n')
    else:
        f.write(data)

# создаём (или открываем существующий) файл для записи
fwrite = open('result.txt', 'w+', encoding='utf-8')

# открываем файл для чтения (с модификатором 'r')
fread = open('source_data.txt', 'r', encoding='utf-8')
# извлекаем ФИО из файла - обрабатываем первую считанную строку из файла, удаляя символ новой строки ('\n')
fio_full = fread.readline().replace('\n', '')
# удаляем из 'fio_full' пробелы, так как по условию в подсчёт символов входить не должны
fio = fio_full.replace(' ', '')
# записываем следующую строку файла в переменную 'id', конвертируя его в тип int 
id = int(fread.readline())
# работа с данными из файла 'source_data.txt' завершена - закрываем его
fread.close()

file_write_line(fwrite, f"1. Исходные данные: {fio_full}; ID: {id}") # записываем этап в файл

# записываем результат деления id на длину ФИО в 'div_result', приводя его к целочисленному виду
div_result = int(id / len(fio))

file_write_line(fwrite, f"2. {div_result}") # записываем этап в файл

# определяем булевую переменную для определения вида сортировки
# если остаток от деления на 2 больше 0 (число нечётное) - сортируем по убыванию
is_desc = div_result % 2 > 0

# формируем переменные-ключи для их дальнешего использования в записываемом файле 
sort_type_str = "по убыванию" if is_desc else "по возрастанию"
even_type_str = "нечётное" if is_desc else "чётное"

file_write_line(fwrite, f"3. Направление сортировки: {sort_type_str}, так как число {div_result} - {even_type_str}") # записываем этап в файл

# формируем новый список - на каждый символ ФИО добавляем в список его код Юникода
unis = [ord(symbol) for symbol in fio]

file_write_line(fwrite, f"4. Набор данных: {unis}") # записываем этап в файл

# производим сортировку двумя способами - вставками и пузырьком
sort_insertion(unis, is_desc) # вставками
sort_bubble(unis, is_desc) # пузырьком

file_write_line(fwrite, f"5. Отсортированный {sort_type_str} набор данных {unis}") # записываем этап в файл

# получаем среднее арифметическое значение
list_average = get_list_average(unis)
file_write_line(fwrite, f"6. Среднее арифметическое значение: {round(list_average, 3)}") # записываем этап в файл

# получаем среднее квадратическое значение
list_average_square = get_list_average_square(unis)
file_write_line(fwrite, f"7. Среднее квадратическое значение: {round(list_average_square, 3)}", add_nl=False) # записываем этап в файл

fwrite.close() # обязательно закрываем файл 'result.txt'