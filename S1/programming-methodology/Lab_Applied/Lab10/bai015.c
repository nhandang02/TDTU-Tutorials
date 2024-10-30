#include <stdio.h>


int search(int a[], int n, int k)
{
	int i;
	for(i = 0; i < n; i++)
	{
		if(a[i] == k)
		{
			return i;
		}
	}
	
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
	
	printf("Gia tri duoc tim thay tai vi tri %d", search(a, n, k));
return 0;
}
