#include <stdio.h>

double Pown(int i, int n);
int main(){
	int n;
	int i= 2;
	
	printf("Enter n: ");
	scanf("%d", &n);
	
	printf("2^n = %.0lf", Pown(i, n));
	
	return 0;
}

double Pown(int i, int n){
	if(n == 1)
		return i;
	if(n == 0)
		return 1;
	else
		return Pown(i, n-1) * i;
}
