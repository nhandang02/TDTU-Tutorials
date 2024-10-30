#include <stdio.h>

int xuatbinary(int x)
{
	if(x < 2)
	{
		printf("%d", x);
		return;
	}
	
	int du = x % 2;
	x = x/ 2;
	xuatbinary(x);
	printf("%d", du);
}

int main()
{
	int n;
	printf("Nhap so can chuyen doi: ");
	scanf("%d", &n);
	
	xuatbinary(n);
	
	return 0;
}
