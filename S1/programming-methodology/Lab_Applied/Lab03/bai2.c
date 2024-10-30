#include <stdio.h>
int main() {
   	int n;
    	
    do {
	printf("nhap so n: ");
    scanf("%d", &n);
	} while(n <= 0);
		
int sum1(int n) {
	int sum = 0, i;
	for(i=1; i <= n; i+=2) {
		sum+=i;} 
	return sum; }	
	int sum = sum1(n);
	    
	printf("tong cac so le tu 1 den %d la: %d", n, sum);
}
