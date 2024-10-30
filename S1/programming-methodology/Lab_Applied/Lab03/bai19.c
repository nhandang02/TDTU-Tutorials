#include <stdio.h>
int main(){
	int n;
	printf("nhap so n: ");
	scanf("%d", &n);
	while(n<0) {
		printf("nhap so n > 0: ");
		scanf("%d", &n);
	}
	int P = tich(n);
	printf("P = %d", P);
}

int tich(int n) {
	int i, P=1;
	for(i=1; i<=n; i++) {
		P*=i;
	}
	return P;
}
