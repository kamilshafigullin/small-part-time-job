//  У гусей и кроликов вместе 64 лапы. Сколько может быть кроликов и гусей (указать все сочетания)? 
#include <iostream>

using namespace std;

int main()
{
    for (int i = 0; i <= 16; i++)
    {
        cout << "Кроликов: " << i << " Гусей: " << (64 - i * 4) / 2 << endl;
    }
}