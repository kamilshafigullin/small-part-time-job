#include <iostream>
#include <fstream>
#include <string>

using namespace std;

typedef struct employee {
    string lastname;
    int salary;
    int years;
} employee;

typedef struct new_employee {
    string lastname;
    int salary;
    int diff;
} new_employee;

int main()
{
    char filename[20];
    cout << "Введите имя файла: ";
    cin.getline(filename, 20);
    ifstream myfile(filename);

    cout << "Введите кол-во сотрудников: ";
    int N;
    cin >> N;

    employee employees[100];
    int i = 0;
    string line;

    int sum = 0; //сумма зарплат
    for (int i = 0; i < N; i++)
    {
        (myfile >> employees[i].lastname).get();
        (myfile >> employees[i].salary).get();
        (myfile >> employees[i].years).get();

        sum += employees[i].salary;
    }
    //средняя зарплата
    int avg = sum / N;
    cout << "Средняя зарплата среди сотрудников: " << avg << endl;

    new_employee new_employees[100];
    int j = 0; //индексатор массива new_employees
    for (int i = 0; i < N; i++)
    {
        if (employees[i].salary > avg)
        {
            new_employees[j].lastname = employees[i].lastname;
            new_employees[j].salary = employees[i].salary;
            new_employees[j].diff = employees[i].salary - avg;
            cout << new_employees[j].lastname << " " << new_employees[j].salary << " " << new_employees[j].diff << endl;
            j++;
        }
    }

    myfile.close();
}