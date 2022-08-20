#include <iostream>

using namespace std;

int main()
{
    int N;
    cout << "Введите N: ";
    cin >> N;

    bool result = N % 2 == 0 && N >= 10 && N <= 99;
    cout <<  boolalpha << result << endl;
}