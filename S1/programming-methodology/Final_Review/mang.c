#include <stdio.h>

//int Tongchan(int a[], int n){
//	int i, s=0;
//	for(i=0; i<n; i++){
//		if(a[i]%2==0) s+=a[i];
//	}
//	return s;
//}

int check(int a[], int n, int x){
	int i, j, count=0;
	for(i=0; i<n; i++){
		if(a[i]==x){
			for(j=i; j<n; j++){
				a[j]=a[j+1];
			}
		n--;
		}
	}
	for(i=0; i<n; i++){
		printf("%d ", a[i]);
	}
}

int main(){
	int a[100], n, i, x;
	
	printf("Nhap kich thuoc mang: ");
	scanf("%d", &n);
	
	for(i=0; i<n; i++){
		printf("Nhap phan tu thu %d: ", i+1);
		scanf("%d", &a[i]);
	}
	
	
	printf("Nhap so can dem trong mang: ");
	scanf("%d", &x);
	
	check(a,n,x);
//	printf("S = %d", Tongchan(a,n));
}
