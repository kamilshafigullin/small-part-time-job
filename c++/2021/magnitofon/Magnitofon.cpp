#include <iostream>
#include "Magnitofon.h"

int main()
{
    Magnitofon magnitofon { FM, speed1, level2 }; //создание объекта по умолчанию, вызов конструктора с параметрами
    std:: cout << "Текущее состояние магнитофона:" << std::endl;
    magnitofon.Print();
    std::cout << "1 - Изменить значения Тюнера" << std::endl;
    std::cout << "2 - Изменить значения cкорости движения магнитной ленты" << std::endl;
    std::cout << "3 - Изменить значения уровня шумов" << std::endl;
    std::cout << "4 - Выйти" << "\n\n";
    char input;
    while (true)
    {
        std::cin >> input;
        switch(input)
        {
            case '1':
                magnitofon.ChangeTuner();
                break;
            case '2':
                magnitofon.ChangeSpeed();
                break;
            case '3':
                magnitofon.ChangeNoisesLevel();
                break;
            case '4':
                magnitofon.ChangeNoisesLevel();
                std::cout << "Всего доброго!" << std::endl;
                return 0;
        }
        magnitofon.Print(); //Вывод значений полей обновлённого класса на консоль
    }
}