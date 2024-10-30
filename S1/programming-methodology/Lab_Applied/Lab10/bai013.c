#include <stdio.h>

int kiemtragio(int x)
{
	int phut, gio, giay;
	
	gio = x / 3600;
	x = x % 3600;
	phut = x / 60;
	giay = x % 60;
	
	printf("%dh\n", gio);
	printf("%dmin\n", phut);
	printf("%ds\n", giay);
	
}

int main()
{
	int n;
	printf("Nhap so giay can quy doi: ");
	scanf("%d", &n);
	kiemtragio(n);
	
	return 0;
}
