#include <stdio.h>

int sum(int a[], int n){
	int S=0, i;
	for(i=0; i<n; i++){
		if(a[i] < 0){
			S+=a[i];
		}
	}
	return S;
}

int main(){
	int a[] = {1, 3, 5, -4, -6, 10, 15};
	printf("Sum all non-positive number int array = %d", sum(a, 7));
}
