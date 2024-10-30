#include <stdio.h>
int sum(int a[], int n){
	int i, S=0;
	for(i=0; i<n; i++){
		S+=a[i];
	}
	return S;
}
int main(){
	int a[] = {1, 3, 5, 9, 15};
	printf("Sum all numbers in array = %d", sum(a, 5));
}

