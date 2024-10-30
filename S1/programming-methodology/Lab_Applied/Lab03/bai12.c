#include <stdio.h>
int main() {
	int n, flag;
	printf("nhap n: ");
    scanf("%d", &n);
    while (n<2) {
    	printf("nhap n >=2: ");
    	scanf("%d", &n);
	}
	
    return tim(n);			
}

int tim(int n) {
	int flag = 0, i;
	for(i=2; i<=n/2; i++) {
		if(n % i == 0) {
			flag = 1;
			break; }
	    }
	if(flag == 0) {
			printf("%d la so nguyen to", n);
		}
		else {
			printf("%d khong la so nguyen to", n);
		}	 
}
