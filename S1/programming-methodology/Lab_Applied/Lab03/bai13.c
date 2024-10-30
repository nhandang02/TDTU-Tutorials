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
	int a, socuoi, sum = 0, i;
	int num = n;
	a = log10(n) + 1;
	for(i=1; n!=0; i++) {
		socuoi = n % 10;
		sum+= pow(socuoi,a);
		n/=10;
	}
	
	if(sum==num) {
		printf("%d is a armstrong number ", num);
	}
	else {
		printf("%d isn't a armstrong number ", num);
	}
}
