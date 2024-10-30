#include <stdio.h>
int main() {
    int n;
    printf("nhap so n: ");
    scanf("%d", &n);
    	
int dem1(int n) {
    int i;
	for(i=0; n != 0; i++) {
		n = n / 10; }
	return i;}
	int v = dem1(n);
		
	printf("so %d co %d chu so", n, v );
}
