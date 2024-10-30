#include <stdio.h>
#define pi 3.1415926535

int main(){
	double cv, dt, d, r;
	
	printf("Nhap chu vi hinh tron: ");
	scanf("%lf", &cv);
	
	d = cv/pi;
	r=d/2.0;
	dt=r*r*pi;
	
	printf("Dien tich hinh tron la: %lf", dt);
}
