#include <stdio.h>

int timmin(int a[], int n)
{
	int i, min = a[0];
	for(i = 0; i < n; i++)
	{
		if(min > a[i])
		{
			min = a[i];
		}
	}
	return min;
}

int main()
{
	int i, n;
	int a[100];
	
	printf("Nhap kich thuong mang: ");
	scanf("%d", &n);
	
	for(i = 0; i < n; i++)
	{
		printf("Nhap mang [%d]: ", i);
		scanf("%d", &a[i]);
	}
	
	printf("So nho nhat trong mang la: %d", timmin(a, n));
return 0;
}
