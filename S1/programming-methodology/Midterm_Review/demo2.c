#include <stdio.h>
int main(){
	int d, Sotien;
	
	printf("Nhap quang duong khach da di: ");
	scanf("%d", &d);
	
	if(d<=1)
		Sotien = d*18000;
	else if(d>1 && d<=10)
		Sotien = 18000+ (d-1)*8000;
	else if (d>10 && d<=30)
		Sotien =18000 + 9*8000 + (d-10)*6000;
	else if(d>30)
		Sotien = 18000 + 9*8000 + 20*6000 + (d-30)*4000;
	
	printf("So tien can thanh toan la: %d VND", Sotien);
	
	return 0;
}
