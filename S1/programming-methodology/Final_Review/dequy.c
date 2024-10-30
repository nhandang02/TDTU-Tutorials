#include <stdio.h>

//int f(int n){
//	if(n==0) return 1;
//	else if(n==1) return 2;
//	else return 2*f(n-1)+3*f(n-2);
//}
//
//void main(){
//	int n;
//	do{
//		printf("Nhap so n: ");
//		scanf("%d", &n);
//	}while(n<0);
//	printf("ket qua cua ham de quy la: %d", f(n));
//}

void NhapMang(int a[], int n)
{
	if(n > 0)
	{
		NhapMang(a, (n-1));
		printf("Nhap phan tu thu %d: ",n);
		scanf("%d", &a[n-1]);
	}
}
//
int TongCacPhanTu(int a[], int n)
{
	if(n = 1)
	{
		return TongCacPhanTu(a, n);
		printf("%d", n);
	}
	return TongCacPhanTu(a, (n-1)+n);
	printf("%d", (n-1)+n);
}

void main()
{
	int a[100], n;
	printf("Nhap so phan tu cua mang: ");
	scanf("%d", &n);
	NhapMang(a,n);
	TongCacPhanTu(a, n);
	printf("Tong cac phan tu trong mang la: %d\n", TongCacPhanTu(a,n));
}


//double f(int n){
//	if(n==0) return 1;
//	else return 2*f(n-1)+3/4.0;
//}
//
//void main(){
//	int n;
//	do{
//		printf("Nhap so n: ");
//		scanf("%d", &n);
//	}while(n<0);
//	printf("ket qua cua ham de quy la: %f", f(n));
//}


//double cau9(int n, int i){
//	if(i>n)
//		return 0;
//	else
//		return cau9(n, i+1) + (3*i-1/3.0);
//}
//
//void main(){
//	int n, i=1;
//	do{
//		printf("Nhap so n: ");
//		scanf("%d", &n);
//	}while(n<0);
//	printf("ket qua cua ham de quy la: %f", cau9(n, i));
//}

//int Tong(int a[], int n){
//	if(n==0) 
//		return a[0];
//	return Tong(a,n-1) + a[n];
//}
//double Tb(int a[], int n){
//	return Tong(a,n)/(n*1.0);
//}
//int main(){
//	int n=5;
//	int a[5]={1,2,3,4,5};
//	printf("Trung binh cong cua cac so trong mang la: %f", Tb(a,n));
//}



//int max(int a[], int n){
//	if(n==0) return a[0];
//	else if(a[n]>max(a,n-1)) return a[n];
//}
//
//int main(){
//	int a[100];
//	int n, i;
//	
//	printf("Nhap kich thuoc mang: ");
//	scanf("%d", &n);
//	for(i=0; i<n; i++){
//		printf("Nhap phan tu thu %d: ",i+1);
//		scanf("%d", &a[i]);
//	}
//	
//	printf("Phan tu lon nhat trong mang la: %d", max(a,n));
//}
//



int check(int n){
	int a;
	if(n>0){
		a=n%10;
		if(a<=9) printf("%d", a);
		return check(n/10);
	}  
}
//
//int main(){
//	int n;
//	printf("Nhap so n: ");
//	scanf("%d", &n);
//	printf("So dao nguoc la:");
//	check(n);
//}

