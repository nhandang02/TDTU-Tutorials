#include <stdio.h>

int main(){
	int n;
	
	printf("Enter a number: ");
	scanf("%d", &n);
	
	printf("%d has %d digit", n, count(n));
}

int count(int n){
	if(n<10)
		return 1;
	else
		return count(n/10)+1;
}
