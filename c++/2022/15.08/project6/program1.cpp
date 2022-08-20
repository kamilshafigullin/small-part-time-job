// А. Дана последовательность натуральных чисел а1, а2,..., аn.
// Создать массив из четных чисел этой последовательности. Если таких чисел нет, то вывести сообщение об этом факте.
#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int N;
    cout << "Введите количество вводимых натуральных чисел: ";
    cin >> N;

    vector<int> nums;
    int n = 0;
    for (int i = 0; i < N; i++)
    {
        cin >> n;
        if (n % 2 == 0)
            nums.push_back(n);
    }

    if (nums.size() == 0)
    {
        cout << "Чётных чисел нет." << endl;
    }
    else
    {
        for (int i = 0; i < nums.size(); i++)
            cout << nums[i] << " ";
    }
}