#include <stdio.h>
#include <math.h>

int main(){
	int x, y;
	float y1, y2, y3 , y4, y5;
	printf("Nhap x:");
	scanf("%d", &x);

	//caua
	y1 = 2*pow(x,3) + 5*x*x + 7*x + 15;
	//caub
	y2 = pow(sin(x),2) + pow(cos(x),2) + pow(tan(3*x),2);
	//cauc
	y3 = pow((x+10),(x+5));
	//caud
	y4 = 3*exp(1)*cos(x+1);
	//caue
	y5 = log(x+100);
	
	printf("y1 = %.2f\n", y1);
	printf("y2 = %.2f\n", y2);
	printf("y3 = %.2f\n", y3);
	printf("y4 = %.2f\n", y4);
	printf("y5 = %.2f", y5);
	
	return 0;
}
