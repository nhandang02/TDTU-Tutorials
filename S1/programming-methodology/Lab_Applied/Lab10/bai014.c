#include <stdio.h>

int countDuplicate(int a[], int n, int k)
{
	int i, count = 0;
	for(i = 0; i < n; i++)
	{
		if(a[i] == k)
		{
			count++;
		}
	}
	printf("Xuat hien %d lan", count);
}

int main()
{
	int i, n, k;
	int a[100];
	printf("Nhap kich thuong mang: ");
	scanf("%d", &n);
	
	for(i = 0; i < n; i++)
	{
		printf("Nhap mang [%d]: ", i);
		scanf("%d", &a[i]);
	}
	
	printf("Nhap gia tri can tim kiem: ");
	scanf("%d", &k);
	countDuplicate(a, n, k);
return 0;
}
