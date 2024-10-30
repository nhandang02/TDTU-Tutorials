#include <stdio.h>

int sum(int a[], int n){
	int i, S=0;
	for(i=0; i<n; i++){
		if(a[i] % 2 ==0){
			S+=a[i];
		}
	}
	return S;
}

int main(){
	int a[] = {1, 3, 4, 6, 10};
	printf("Sum all even number in array = %d", sum(a, 5));
}
