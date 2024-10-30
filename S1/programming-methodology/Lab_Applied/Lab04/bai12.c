#include <stdio.h>
#define N 100
merge(int c[], int n1, int n2, int a[], int b[]){
	int i;
	for(i=0; i<n1+n2; i++){
		if(i<n1){
			c[i]=a[i];
		}
		else{
			c[i]=b[i-n1];
		}
	}
	printf("1st array is : ");
	for(i=0; i<n1; i++){
        printf("%d\t", a[i]);
    }
    
    printf("\n");
    
	printf("2nd array is : ");
	for(i=0; i<n2; i++){
        printf("%d\t", b[i]);
    }
    
    printf("\n");
    
	printf("3nd array is : ");
	for(i=0; i<n1+n2; i++){
        printf("%d\t", c[i]);
    }
}

int main(){
	int a[N];
	int b[N];
	int c[N];
	int i, n1, n2;
	
	printf("Enter size of 1st array: ");
	scanf("%d", &n1);;
	printf("Eter elements of 1st array: ");
	for(i=0; i<n1; i++){
		scanf("%d", &a[i]);
	}
	
	printf("Enter size of 2nd array: ");
	scanf("%d", &n2);
	printf("Enter elements of 2nd array: ");
	for(i=0; i<n2; i++){
		scanf("%d", &b[i]);
	}
	
	return merge(c, n1, n2, a, b);
}
