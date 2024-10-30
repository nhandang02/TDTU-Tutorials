#include <stdio.h>

int timmax(int a[], int n)
{
	int i, max = a[0];
	for(i = 0; i < n; i++)
	{
		if(max < a[i] )
		{
			max = a[i];
		}
	}
	return max;
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
	
	printf("So lon nhat trong mang la: %d", timmax(a, n));
return 0;
}
