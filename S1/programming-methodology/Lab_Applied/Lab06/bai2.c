#include <stdio.h>

int Fac(int n);
int main(){
	int n;
	
	printf("Enter a number: ");
	scanf("%d", &n);
	
	printf("Facturial of %d is: %d", n, Fac(n));
	
	return 0;
}

int Fac(int n){
	if(n>=1)
		return Fac(n-1)*n;
	else
		return 1;
}
