#include <stdio.h>
#include <math.h>

int main(){
	int xA,yA, xB,yB;
	double d;
	
	
	printf("Nhap diem A: ");
	scanf("%d", &xA);
	scanf("%d", &yA);
	printf("Nhap diem B: ");
	scanf("%d", &xB);
	scanf("%d", &yB);
	
	d = sqrt(pow((xA-xB),2) + pow((yA-yB),2));
	
	printf("Khoanng cach giua A va B la: %lf", d);
}
