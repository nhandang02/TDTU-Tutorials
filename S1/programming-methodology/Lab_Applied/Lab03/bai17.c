#include <stdio.h>
int main() {
	int n;
	printf("nhap so n: ");
    scanf("%d", &n);
    while(n<0) {
        printf("nhap so n>0 : ");
        scanf("%d", &n);
	}
	
	return check(n);
}


int check(int n) {
	int i, x;
	for (i=1; i<=n; i++) {
		int sum = 0;
		for (x=1; x<i; x++) {
			if (i%x == 0) {
				sum += x;
		    }	
		}
		if (sum == i) {
			printf("%d ", i);
		}
	}
}
	
