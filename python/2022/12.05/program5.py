class Students :
    '''Студенты'''
    students_list = []

    def __init__(self, fio, group):
        self.fio = fio
        self.group = group
        self._university = "Harvard" # определяем закрытый атрибут

        Students.students_list.append(f"{fio}|{group}")

    def __str__(self):
        return f"ФИО студента {self.fio} | группа {self.group}"

    def __del__(self):
        if (Students.students_list.__contains__(self.fio)):
            Students.students_list.remove(f"{self.fio}|{self.group}")
            print(f"Студент {self.fio} удалён")

    @staticmethod
    def is_have_student(fio, group): # статический метод (определяет, есть ли в списке некоторый студент)
        if (Students.students_list.__contains__(f"{fio}|{group}") == True):
            print(f"Студента с ФИО {fio} с группой {group} есть в списке")
        else:
            print(f"Студента с ФИО {fio} с группой {group} нет в списке")
        
    def change_fio(self, new_fio): # метод экземпляра класса
        self.fio = new_fio
        print("ФИО успешно изменены")


student1 = Students("Александр В.И.", "4204")
print(student1)

student2 = Students("Артём О.Г.", "2315")
Students.is_have_student("Артём О.Г.", "2315")
Students.__del__(student2)

student3 = Students("Григорий В.Л.", "3125")
print(student3)
student3.change_fio("Григорий В.М.")
print(student3)

