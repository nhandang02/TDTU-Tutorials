#include <stdio.h>
int main ()
{
	float a,b, max;
	printf("\nnhap a = ");
	scanf("%f", &a);
	printf("\nnhap b = ");
	scanf("%f", &b);
	
	if (a > b)
	    max = a;
	else
        max = b;
	
	printf("\nmax(%f, %f)= %f ",a, b, max);
	
	return 0;		
}



