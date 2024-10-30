#include <stdio.h>
int main()
{
	float a,b,c,max;
	printf("\nnhap a = ");
	scanf("%f", &a);
	printf("\nnhap b = ");
	scanf("%f", &b);
	printf("\nnhap c = ");
	scanf("%f", &c);
	
	max = a;
	if (max < b)
	max = b;
	if (max < c)
	max = c;
	printf("\nmax=(%f %f %f)= %f ",a, b, c, max);
	
	return 0 ;
	
}
