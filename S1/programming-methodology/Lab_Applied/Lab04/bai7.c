#include <stdio.h> 

int reverse(int a[], int n){
	int i,t;
	for(i=0; i<n/2; i++){
		t = a[i];
	    a[i] = a[n-i-1];
	    a[n-i-1] = t;
	}
	for(i=0; i<n; i++){
		printf("%d ", a[i]);
	}
}

int main(){
	int a[] = {1, 2, 3, 4, 5};
	reverse(a, 5);
}
