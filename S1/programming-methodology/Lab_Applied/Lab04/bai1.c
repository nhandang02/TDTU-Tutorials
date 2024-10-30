#include <stdio.h>
int Facturial(int n){
	int x, F=1;
	for(x=2; x<=n; x++){
		F*=x;
	}
	return F;
}

//caua
double caua(int n){
	int i; 
	double S1=0;
	for(i=1; i<=n; i++){
		S1+=i/2.0;
	}
	return S1;
}

//caub
int caub(int n){
	int i, S2=0;
	for(i=1; i<=n; i++){
		S2+=2*i + 1;
	}
	return S2;
}

//cauc
long cauc(int n){
	int i; 
	long S3=0;
	for(i=1; i<=n; i++){
		S3+=Facturial(i) + 1;
	}
	return S3;
}

//caud
long caud(int n){
	int i; 
	long S4=1;
	for(i=1; i<=n; i++){
		S4*=Facturial(i);
	}
	return S4;
}

//caue
double caue(int n){
	int i; 
	double S5=1;
	for(i=1; i<=n; i++){
		S5*=(2*i) / (3.0);
	}
	return S5;
}
int main(){
	int n;
	
	printf("nhap so n: ");
	scanf("%d", &n);
	
	printf("cau a = %lf\n", caua(n));
	printf("cau b = %d\n", caub(n));
	printf("cau c = %d\n", cauc(n));
	printf("cau d = %d\n", caud(n));
	printf("cau e = %lf\n", caue(n));
	
	return 0;
}
