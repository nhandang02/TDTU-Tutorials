#include <stdio.h>

int cau1(int x)
{
	int i, sum1 = 0;
	for(i = 0; i < x; i++)
	{
		sum1 += 2*i+1;
	}
	return sum1;
}

int cau2(int y)
{
	int i, sum2 = 0, factor = 0;
	for(i = 0; i < y; i++)
	{
		factor *=i;
		sum2 += factor + 1;
	}
	return sum2;
}

float cau3(int z)
{
	float i;
	float sum3 = 0;
	for(i = 0; i < z; i++)
	{
		sum3 += (2*i+1)/1.0*i;
	}
return sum3;
}

int main()
{
	int n;
	
	printf("Nhap gia tri n can tinh: ");
	scanf("%d", &n);
	
	printf("Ket qua cau a la %d\n", cau1(n));
	printf("Ket qua cau b la %d\n", cau2(n));
 	printf("Ket qua cau c la %f\n", cau3(n));
	
	return 0;
}


