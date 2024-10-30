#include <stdio.h>
#include <math.h>
int main(){
	int x, y;
	float S;
	
	printf("Nhap so x: ");
	scanf("%d", &x);
	printf("Nhap so y: ");
	scanf("%d", &y);
	
	S = ((pow(x,3)*3*y - 1/2*x*x + 1/5*x*y)*6*x*pow(y,3));
	
	printf("Ket qua cua bieu thuc la: %.2f", S);
	
	return 0;
}
