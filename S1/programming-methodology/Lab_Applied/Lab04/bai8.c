#include <stdio.h>
#define MAX_SIZE 100
int delete(int a[], int n, int pos){
	int i;
	for(i=pos-1; i<n-1; i++){
		a[i] = a[i+1];
	}
	printf("\nElements of array after delete are : ");
    for(i=0; i<n-1; i++){
        printf("%d\t", a[i]);
    }
}

int main(){
    int a[MAX_SIZE];
    int i, n, pos;

    printf("Enter size of the array : ");
    scanf("%d", &n);
    printf("Enter elements in array : ");
    for(i=0; i<n; i++){
        scanf("%d", &a[i]);
    }

    printf("Enter the element position to delete : ");
    scanf("%d", &pos);

    return delete(a, n, pos);
}
