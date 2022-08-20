// B. Натуральное число M называется совершенным, если оно равно сумме всех своих делителей, включая 1, но исключая себя.
// Напечатать все совершенные числа меньшие заданного числа N. 
#include <iostream>

using namespace std;

int get_dividers_sum(int n)
{
    int sum = 0;
    for (int i = 1; i < n; i++)
        if (n % i == 0)
            sum += i;

    return sum;
}

int main()
{
    int *seq;
    int count;
    cout << "Введите последовательность чисел, которые нужно проверить на совершенность: ";
    cin >> count;
    seq = (int*)malloc(sizeof(int) * count);
    for (int i = 0; i < count; i++)
        cin >> seq[i];

    int N;
    cout << "Введите N: ";
    cin >> N;

    for (int i = 0; i < count; i++)
    {
        if (seq[i] < N && seq[i] == get_dividers_sum(seq[i]))
            cout << seq[i] << endl;
    }
}