#include <stdio.h>
#include <math.h>

int main(){
	int x;
	float fx;
	
	printf("Nhap x: ");
	scanf("%d", &x);
	
	if(x<0)
		fx = sin(x)*cos(x);
	else if(x==0)
		fx = pow(5,x);
	else if(x>0 && x<5)
		fx = pow(exp(1),x);
	else if(x>=5)
		fx = pow(5,x)/(x+5);
	
	printf("F(x) = %.2f", fx);
	
	return 0;
}
