#include <stdio.h>
#include <math.h>
int main() {
	int n;
	
	printf("Enter n: ");
	scanf("%d", &n);
	while(n<10) {
		printf("Enter n >= 10");
		scanf("%d", &n);
	}
	
	return check(n);
}

int check(int n) {
	int a, j, N, socuoi, sum = 0, i;
	a = log10(n) + 1;
	for(j=1; j<=n; j++) {
        sum = 0;
		N = j;
		a =  log10(N) + 1;
		
		while(N > 0) {
		socuoi = N % 10;
        sum = sum + pow(socuoi, a);
		N = N / 10;
		}
		
		if(j == sum) {
		printf("%d ", j);
		}
	}
}
