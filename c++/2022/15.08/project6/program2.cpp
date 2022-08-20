// В. Даны действительные числа а1, а2,..., аn.
// Среди них есть положительные и отрицательные.
// Заменить нулями те числа, величина которых по модулю больше максимального числа
#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int N;
    cout << "Введите N: ";
    cin >> N;

    vector<int> nums;
    int n;
    int max = -10000;
    for (int i = 0; i < N; i++)
    {
        cin >> n;
        nums.push_back(n);
        if (nums[i] > max)
            max = nums[i];
    }

    for (int i = 0; i < N; i++)
    {
        if (abs(nums[i]) > max)
            nums[i] = 0;
        cout << nums[i] << " ";
    }
}