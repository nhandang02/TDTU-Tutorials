#include <stdio.h>
#include <math.h>
int main(){
	float xO, yO, xA, yA;
	int R, dOA;
	
	printf("Nhap ban kinh R: ");
	scanf("%d", &R);
	
	printf("Nhap toa do diem O: ");
	scanf("%f%f", &xO , &yO);
	
	printf("Nhap toa do diem A: ");
	scanf("%f%f", &xA , &yA);
	
	dOA = sqrt(pow((xA-xO),2) + pow((yA-yO),2));
	
	if(dOA<=R)
		printf("Diem A nam trong duong tron tam R");
	else if(dOA=R)
		printf("Diem A nam tren duong tron tam R");
	else
		printf("Diem A nam ngoai duong tron tam R");
	return 0;
}
