#include <stdio.h>

int sochan(int a[], int n)
{
	int i;
	int sum = 0;
	for(i = 0; i < n; i++)
	{
		if(a[i] % 2 != 0)
		{
			sum += a[i];
		}
	}
	return sum;
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
	
	printf("Tong cac so le trong mang la: %d", sochan(a, n));
return 0;
}
