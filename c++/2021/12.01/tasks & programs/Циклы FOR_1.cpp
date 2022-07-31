// 9.	Составьте программу, вычисляющую A*B, не пользуясь операцией умножения. А и B любое натуральное число.  
#include <iostream>

using namespace std; 

int main()
{
    //A * B
    int R = 0;

    int A, B;
    cout << "Введите А" << endl;
    cin >> A;
    cout << "Введите B" << endl;
    cin >> B;
    
    for (int i = 0; i < A; i++)
        R += B;
    
    cout << "A * B: " << R << endl;
}