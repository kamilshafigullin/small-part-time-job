# Cоздать датафрейм на основе StudentsPerformance.csv. Вычислить средний балл по математике у ребят со стандартным ланчем

import pandas as pd # импортируем библиотеку

# считываем csv-файл в датафрейм
df = pd.read_csv('StudentsPerformance.csv')

# вычисляем сумму по отбору столбца 'lunch' по значению 'standart'
sum = df[df['lunch'] == 'standard']['math score'].sum()

# вычисляем количество строк, удовлетворяющих условию 'lunch' == 'standart'
count = df[df['lunch'] == 'standard'].shape[0]

# вычисляем среднее значение и выводим
average_sum = sum / count
print(average_sum)