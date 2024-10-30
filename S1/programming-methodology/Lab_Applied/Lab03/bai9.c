#include <stdio.h>
#include <math.h>
int swap1(int n) {
	int a, b, c, d, sodau, socuoi, swap;
	a = log10(n);
	b = pow(10,a);
	c = n % b;
	d = c / 10;
	sodau = n / b;
	socuoi = n % 10;
	swap = (socuoi * pow(10,a) + (d * 10 + sodau));
	
	return swap; }


int main() {
	int n;
	do {
		printf("nhap so n: ");
	    scanf("%d", &n);
	}
	while (n <= 10);
	
	printf("so sau khi doi so dau va so cuoi la: %d", swap1(n)); }


