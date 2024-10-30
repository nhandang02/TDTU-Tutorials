#include <stdio.h>

int f(int x)
{
	if(x <= 1)
	{
		return 1;
	}
	
return x*f(x - 1);	
}

int main()
{
	int n;
	printf("Nhap so n: ");
	scanf("%d", &n);
	
	printf("Ket qua la %d", f(n));
	
	return 0;
}

