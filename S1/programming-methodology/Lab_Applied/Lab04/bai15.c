#include <stdio.h>
#define N 100

int sort(int a[], int n){
	int i, j, T;
	for(i=0; i<n; i++){
		for(j=i+1; j<n; j++){
			if(a[i]>a[j]){
				T=a[i];
				a[i]=a[j];
				a[j]=T;
			}
		}
	}
	printf("Array elements in ascending oder: ");
	for(i=0; i<n; i++){
		printf("%d\t", a[i]);
	}
}

int main(){
	int n, i;
	int a[N];
	
	printf("Enter size of array: ");
	scanf("%d", &n);
	
	printf("Enter elements of array: ");
	for(i=0; i<n; i++){
		scanf("%d", &a[i]);
	}
	
	return sort(a, n);
}
