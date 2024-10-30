#include <stdio.h>

int f(int x)
{
	if(x == 0)
	{
		return 1;
	}
	else if(x == 1)
	{
		return 2;
	}
	
return 2*f(x - 1) + 3*f(x - 2);	
}

int main()
{
	int n;
	printf("Nhap so n: ");
	scanf("%d", &n);
	
	printf("Ket qua la %d", f(n));
	
	return 0;
}

