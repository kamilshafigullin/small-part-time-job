#ifndef MACROS_NAME
#define MACROS_NAME
enum TunerEnum
{
    TV,
    FM
};

char *TunerTypes[] =
{
    "TV",
    "FM"
};

enum SpeedEnum
{
    speed1 = 10,
    speed2 = 12
};

enum NoisesLevelEnum
{
    level1 = 7,
    level2 = 9
};

class Magnitofon
{
private:
    TunerEnum tuner;        //Тюнер
    int speed;              //Скорость движения магнитной ленты
    int noisesLevel;        //уровень шумов
public:
    //конструктор
    Magnitofon(TunerEnum tuner, int speed, int noisesLevel)
    {
        this->tuner = tuner;
        this->speed = speed;
        this->noisesLevel = noisesLevel;
    }
    //изменение поля Tuner
    void ChangeTuner()
    {
        //тернарный оператор
        tuner = tuner == TV ? FM : TV;
    }
    //изменение скорости движения магнитной ленты
    void ChangeSpeed()
    {
        //тернарный оператор
        speed = speed == speed1 ? speed2 : speed1;
    }
    //изменение уровня шумов
    void ChangeNoisesLevel()
    {
        //тернарный оператор
        noisesLevel = noisesLevel == level1 ? level2 : level1;
    }
    //распечатать значения полей
    void Print()
    {
        std::cout << "Тюнер: ";
        std::cout << TunerTypes[tuner] << std::endl;
        std::cout << "Cкорости движения магнитной ленты: ";
        std::cout << speed << std::endl;
        std::cout << "Уровень шумов: ";
        std::cout << noisesLevel << std::endl << std::endl;
    }
};
#endif   //  MACROS_NAME