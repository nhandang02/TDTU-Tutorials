#include <stdio.h>
int main()
{
	int a,b,S,P;
	printf("nhap a = ");
	scanf("%d", &a);
	printf("nhap b = ");
	scanf("%d", &b);
	
	S= a * b;
	P=2*(a + b);
	printf("S= %d  ",S);
	printf("P= %d",P);	
	
	return 0;
}
