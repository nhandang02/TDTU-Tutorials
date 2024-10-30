#include <stdio.h>
int main() {
	long  binary;
	int n;
	printf("nhap so thap phan : ");
	scanf("%d", &n);
	binary = swap(n);
	printf("so nhi phan la: %d", binary);
}
int swap(int n) {
	long binary=0, rem, f=1;
	while(n !=0 ) {
		rem = n%2;
		binary+= rem*f;
		f*=10;
		n/=2;
	}
	return binary;
}
