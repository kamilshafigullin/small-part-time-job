#include <iostream>
using namespace std;

struct my_struct
{
    float data;
    my_struct *next;
};

int do_work(my_struct* head)
{
    int result = 0;

    my_struct *temp = head;
    while (temp != NULL)
    {
        temp = temp->next;
        // подсчёт количества
        result++;
        
        if (temp->next == NULL)
        {
            result++;
            // делаем список кольцевым
            temp->next = head;
            break;
        }
    }

    return result;
}

int main()
{
    my_struct struct1;
    struct1.data = 2.5;
    my_struct struct2;
    struct1.data = 5.1;
    my_struct struct3;
    struct1.data = 8.3;

    struct1.next = &struct2;
    struct2.next = &struct3;

    my_struct* head = &struct1;
    cout << do_work(head); // 3
}

