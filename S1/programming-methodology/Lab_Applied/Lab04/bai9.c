#include <stdio.h>
#define MAX_SIZE 100

int count(int a[], int n){
	int i, j, C=0;
	int x = a[0];
	for(i=0; i<n; i++){
		for(j=i+1; j<n; j++){
			if(a[i] == a[j]){
			C++;
			break;
		    } 
	    }
    }
	return C;
}

int main(){
	int i, n, a[MAX_SIZE];
    printf("Enter size of the array : ");
    scanf("%d", &n);
    printf("Enter elements in array : ");
    for(i=0; i<n; i++){
        scanf("%d", &a[i]);
    }
	
	printf("Total number of dulicate element in array = %d", count(a, n));
	return 0;
}
