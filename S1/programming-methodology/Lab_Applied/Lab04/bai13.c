#include <stdio.h>
#define N 100
int separate(int a[], int b[], int c[], int n) {
	int i;
	int j=0, k=0;
	for(i=0; i<n; i++){
		if(a[i]%2==0){
			b[j]=a[i];
			j++;
		}
		else{
			c[k]=a[i];
			k++;
		}
	}
	printf("Even array is: ");
	for(i=0; i<j; i++){
		printf("%d\t", b[i]);
	}
	printf("\n");
	printf("Odd array is: ");
	for(i=0; i<k; i++){
		printf("%d\t", c[i]);
	}
}

int main(){
	int i,n;
	int a[N], b[N], c[N];
	
	printf("Enter size if the array: ");
	scanf("%d", &n);
	
	printf("Enter elements of the array: ");
	for(i=0; i<n; i++){
		scanf("%d", &a[i]);
	}
	return separate(a, b, c, n);
}
