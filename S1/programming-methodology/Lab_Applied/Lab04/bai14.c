#include <stdio.h>
#define N 100

int search1(int a[], int n, int search){
	int i, found=0;
	for(i=0; i<n; i++){
		if(a[i]==search){
			found = 1;
			break;
		}
	}
	if(found=1){
		printf("%d is found at position %d", search, i+1);
	}
	else{
		printf("%d is not found in the array ", search);
	}
}

int main(){
	int i, n, search, a[N];
	
	printf("Enter size of array: ");
	scanf("%d", &n);
	
	printf("Enter elements of array: ");
	for(i=0; i<n; i++){
		scanf("%d", &a[i]);
	}
	printf("Enter number to search: ");
	scanf("%d", &search);
	
	return search1(a, n, search);
}
