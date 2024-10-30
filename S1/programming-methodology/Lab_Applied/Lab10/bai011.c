#include <stdio.h>

int ktnt(int x)
{
	int i;
	
	if(x<2)
	{
		return 0;
	}
		
	for(i=2; i<=x/2; i++)
	{
		if(x % i == 0)
			return 0;
	}
		
	return 1;
}

int bai11(int a[], int x)
{
	int i, sum = 0;
	for(i = 0; i < x; i++)
	{
		if(ktnt(a[i]))
		{
			sum += a[i];
		}
	}
	return sum;
}

int main()
{
	int i, n;
	
	int a[50];
	
	printf("So phan tu trong mang ");
	scanf("%d",&n);
	
	for(i=0 ; i<n ; i++ )
	{
		printf("So phan tu a[%d] la:\n ",i);
		scanf("%d",&a[i]);
	}
	
	printf("Ket qua la %d", bai11(a, n));

return 0;
}
