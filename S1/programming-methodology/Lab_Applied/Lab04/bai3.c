#include <stdio.h>
int min1(int a[], int n){
	int i;
	int min = a[0];
	for(i=1; i<n; i++){
		if(a[i] < min){
			min = a[i];
		}
	}
	return min;
}

int main(){
	int a[] = {8, 4, 6, 9, 15};
	
	printf("Minimum in array is: %d", min1(a, 5));
}
