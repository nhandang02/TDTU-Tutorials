#include <stdio.h>
int main() {
	int n;
	
	do {
    	printf("nhap so n >= 10: ");
    	scanf("%d", &n);
	} while(n < 10);
	
	printf("so sau khi dao nguoc la: %d ", swap1(n));
}


int swap1(int n) {
	int i, swap = 0;
	for(i=1; n!=0 ; i++) {
		swap = swap * 10 + n % 10; 
		n/=10;
	}
	return swap;
}
