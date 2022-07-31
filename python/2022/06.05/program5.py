class Characters :
    '''Персонажи художественных фильмов'''
    character_list = []

    def __init__(self, character, movie, person):
        self.character = character
        self.movie = movie
        self.person = person

        self.__add_character_if_can()

    def __str__(self):
        return "Персонаж: " + self.character + ", " + "Фильм: " + self.movie + ", " + "Актёр: " + self.person

    def __del__(self):
        if (Characters.character_list.__contains__(self.character)):
            Characters.character_list.remove(self.character)
            print("Персонаж {} удалён".format(self.character))

    # закрытый метод экземпляра класса
    def __add_character_if_can(self) -> bool:
        if(Characters.character_list.__contains__(self.character) == False):
            Characters.character_list.append(self.character)
        else:
            print("Персонаж с именем {} уже присутсвует в списке".format(self.character))

    # открытый метод экземпляра класса
    def change_info(self, character, movie, person):
        self.character = character
        self.movie = movie
        self.person = person
        print("Данные успешно применены")


semen = Characters("Семён Владимирович", "Бриллиантовая рука", "Юрий В.Л.")
print(semen)
borodatyi = Characters("Бородатый", "Тарас Бульба", "Борис А.Х.")
print(borodatyi)
borodatyi_copy = Characters("Бородатый", "Тарас Бульба", "Борис А.Х.")
borodatyi.change_info("Бородатый2", "Тарас Бульба", "Борис А.Х.")
print(borodatyi)
delattr(borodatyi, 'movie')
print(Characters.character_list)
print(semen)
semen.__del__()
print(Characters.character_list)


