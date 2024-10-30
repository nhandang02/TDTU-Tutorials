#include <stdio.h>
int main() {
	int n;
	printf("nhap so n: ");
    scanf("%d", &n);
    while(n<0) {
        printf("nhap so n>0 : ");
        scanf("%d", &n);
	}
	
	check(n);
}


int check(int n) {
	int i, sum = 0;
	for(i = 1; i <= n / 2; i++) {
        if(n%i == 0) {
            sum += i;
        }
    }
    
    if(sum == n ) {
        printf("%d la so hoan hao", n);
    }
    else {
        printf("%d khong la so hoan hao", n);
    }
}
