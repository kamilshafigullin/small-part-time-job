#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int n1, n2;
    cin >> n1;
    cin >> n2;

    int is_simple_n1 = 1;
    for (int i = 2; i <= sqrt(n1); i++)
    {
        if (n1 % i == 0)
            is_simple_n1 = 0;
    }

    int is_simple_n2 = 1;
    for (int i = 2; i <= sqrt(n2); i++)
    {
        if (n2 % i == 0)
            is_simple_n2 = 0;
    }

    if (is_simple_n1 == 0)
        cout << "Первое число не является простым числом" << endl;
    else
        cout << "Первое число является простым числом" << endl;

    if (is_simple_n2 == 0)
        cout << "Второе число является составным числом" << endl;
    else
        cout << "Второе число не является составным числом" << endl;
}