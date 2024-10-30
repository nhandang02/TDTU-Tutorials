#include <stdio.h>
int max1(int a[], int n){
	int i;
	int max = a[0];
	for(i=1; i<n; i++){
		if(a[i] > max){
			max = a[i];
		}
	}
	return max;
}

int main(){
	int a[] = {1, 4, 6, 9, 15};
	
	printf("Maximum in array is: %d", max1(a, 5));
}
