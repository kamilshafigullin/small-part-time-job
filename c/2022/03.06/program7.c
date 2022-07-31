/*
* упорядочить заданный массив x следующим образом. Наименьший 
* элемент поместить на первое место, второе по величине - на последнее,
* третий -  на второе, следующий - на препоследнее и тд до серединый массива
*/

#include<stdio.h>
#include<stdlib.h>

void print(int* a, int d)
{
	for (int i = 0; i < d; i++)
	{
		printf("%d\t", a[i]);
	}
	printf("\n");
}

int main()
{
	int* a;
	printf("input size array: ");
	int d;
	scanf("%d",&d);

	a = (int*)malloc(sizeof(int) * d);
	for (int i=0; i <d; i++)
	{
		a[i] = rand() % 15;	
	}
	print(a, d);
	
	int begin = 0;
	int end = d - 1;
	int index = 0;
	int ind = 0;
	while (begin < end)
	{
		int one = a[begin];
		for (int i = begin; i < end; i++)
		{
			if (a[i] < one)
			{
				one = a[i];
				index = i;
			}
		}
		int t = a[begin];
		a[begin] = one;
		a[index] = t;
		
		int two = a[begin+1];
		for (int i = begin + 1; i < end; i++)
		{
			if (a[i] < two)
			{
				two = a[i];
				ind = i;
			}
		}
		t = a[end-1];
		a[end-1] = two;
		a[ind] = t;


		begin++;
		end = end - 1;
	}
	
	print(a, d );
	
	return 0;
}