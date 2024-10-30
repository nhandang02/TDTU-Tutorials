#include <stdio.h>
int main(){
	int m, h,Sotien;
	
	
	printf("Nhap so gio lam viec cua nhan vien: ");
	scanf("%d", &h);
	printf("Nhap so luong co ban: ");
	scanf("%d", &m);
	
	if(h<=40)
		Sotien = h*m;
	else if(40<h && h<=45)
		Sotien = 40*m + ((h-40)*m*1.8);
	else if(45<h && h<=50)
		Sotien = (40*m + (5*m*1.8) + ((h-45)*m*2.5));
	else if(h>50)
		Sotien = (40*m + (5*m*1.8) + (5*m*2.5) + ((h-50)*m*2.6));
	
	printf("Tien luong tong cong la: %d", Sotien);
	
	return 0;
}

