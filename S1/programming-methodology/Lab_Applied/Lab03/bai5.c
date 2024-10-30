#include <stdio.h>
int main() {
   	int n, socuoi;
    do {
    	printf("nhap so n: ");
    	scanf("%d", &n);
	} while(n <= 10);
		
	socuoi = n % 10;
    
int sodau(int n) {
    int sodau, i;
    do {
    	n = n / 10;
	} while(n > 10);
	return n; }
	n = sodau(n);
	    
}
