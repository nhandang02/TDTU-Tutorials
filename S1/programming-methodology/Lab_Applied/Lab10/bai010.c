#include <stdio.h>

int f(int x)
{
	x = x -1;
	
	if(x == 0)
	{
		return 4;
	}
	else if(x == 1)
	{
		return 7;
	}
	
return 4*f(x) + f(x - 1);	
}

int main()
{
	int n;
	printf("Nhap so n: ");
	scanf("%d", &n);
	
	printf("Ket qua la %d", f(n));
	
	return 0;
}

