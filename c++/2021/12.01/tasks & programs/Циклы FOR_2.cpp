// 9.	В каких двузначных числах удвоенная сумма цифр равна их произведению? 
#include <iostream>

using namespace std; 

int main()
{
    int s, p;
    for (int i = 10; i <= 99; i++)
    {
        s = 2* ((i % 10) + (i / 10));
        p = (i % 10) * (i / 10);
        if (s == p)
            cout << i << endl;
    }
}