// A. Дано натуральное число п ≤ 99. Дописать к нему цифру k в конец и в начало
#include <iostream>
#include <sstream>

using namespace std;

std::string number_to_string(int n)
{
    std::ostringstream ss;
    ss << n;
    return ss.str();
}

int main()
{
    int p, k;
    cout << "Введите п: ";
    cin >> p;

    cout << "Введите k: ";
    cin >> k;

    string str = number_to_string(k) + number_to_string(p) + number_to_string(k);
    cout << "Результат: " << str << endl;
}