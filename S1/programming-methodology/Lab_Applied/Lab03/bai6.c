#include <stdio.h>
int main() {
    int n;
    do {
    	printf("nhap so n: ");
    	scanf("%d", &n);
	} while(n < 10);
		
int dem1(int n) {
	int dem = 0, i;
	int m=n;
	while(m) {
		dem+=(m%10);
		m/=10; }
	return dem;} 
int dem = dem1(n);
printf("tong cua cac chu so la: %d", dem);
}
