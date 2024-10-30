#include <stdio.h>

int main(){
	long n, mkh, dtc;
	long dt;
	
	printf("Nhap ma khach hang: ");
	scanf("%d", &mkh);
	
	printf("Nhap diem tra cuu : ");
	scanf("%d", &dtc);
	
	if(mkh<10000000 || mkh>99999999){
		printf("Nhap du lieu khach hang sai");
		return 0;
	}
	if(dtc%1000!=0){
		printf("Nhap du lieu diem tra cuu sai");
		return 0;
	}
	n = mkh / 10000;
	n = n%10;
	if(n>=0 && n<=2)
		dt = dtc*10/100;
	else if(n>2 && n<6)
		dt = dtc*12/100;
	else if(n>5 && n<8)
		dt = dtc*13/100;
	else if(n>7 && n<10)
		dt = dtc*16/100;
	
	printf("Diem thuong: %ld", dt);
	return 0;
}
