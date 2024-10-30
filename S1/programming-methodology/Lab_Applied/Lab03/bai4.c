#include <stdio.h>
int main() {
    int n;
    	
    do {
    	printf("nhap so n: ");
    	scanf("%d", &n);
	} while(n <= 0);
	
int sum1(int n) {
	int sum = 0, i;
	for(i=1; i <= n; i++) {
		sum+=i;}
	return sum;
}	
	int sum = sum1(n);
	    
	printf("tong cac chu so tu 1 den %d =  %d", n, sum);
}
