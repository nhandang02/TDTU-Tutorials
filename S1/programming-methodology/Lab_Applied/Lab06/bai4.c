#include <stdio.h>

double npow(double x, double n);
int main(){
	double n, x;
	
	printf("Enter n: ");
	scanf("%lf", &n);
	
	printf("Enter x: ");
	scanf("%lf", &x);
	
	printf("x^n = %.0lf", npow(x, n));
	
	return 0;
}
double npow(double x, double n){
	if(n == 1)
		return x;
	if(n == 0)
		return 1;
	else
		return npow(x, n-1) * x;
}
