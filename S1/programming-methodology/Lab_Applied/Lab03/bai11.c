#include <stdio.h>
int main() {
	int swap, n;
	
	do {
    	printf("nhap so n >= 10: ");
    	scanf("%d", &n);
	} while(n < 10);
	
	if(swap1(n) == n){
	        printf("%d is palindrome", n);
		} else {
			printf("%d isn't palindrome", n);
        }
	
	
	
}


int swap1(int n) {
	int i, swap = 0;
	for(i=1; n!=0 ; i++) {
		swap = swap * 10 + n % 10; 
		n/=10;
	} return swap;
	
}
