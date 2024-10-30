#include <stdio.h>
#include <math.h>
int Facturial( int n);
double caua(int n);
long caub(int n);
double cauc(int n);
int caud(int n);
double caue(int n);
double cauf(int n);
int main(){
	int n;
	
	do{
		printf("Nhap so n > 0: ");
		scanf("%d", &n);
	} while(n<=0);
	
	printf("Cau a = %f\n", caua(n));
	printf("Cau b = %d\n", caub(n));
	printf("Cau c = %f\n", cauc(n));
	printf("Cau d = %d\n", caud(n));
	printf("Cau e = %f\n", caue(n));
	printf("Cau f = %f", cauf(n));
}

int Facturial( int n){
	int x; 
	int F=1;
	for(x=1; x<n; x++){
		F*=x;
	}
	return F;
}

//cau a
double caua(int n){
	int i;
	double S1=0;
	for(i=1; i<=n; i++){
		S1+=(i+1)/sqrt(i);
	}
	return S1;
}

//cau b
long caub(int n){
	int i;
	long S2=0;
	for(i=1; i<=n; i++){
		S2+= 1/(Facturial(i));
	}
	return S2;
}

//cau c
double cauc(int n){
	int i;
	double S3=0;
	for(i=1; i<=n; i++){
		S3+= (i+1)/(pow(i, 1/3));
	}
	return S3;
}

//cau d
int caud(int n){
	int i;
	int S4=0;
	for(i=2; i<=n; i+=2){
		S4+= 1/i;
	}
	return S4;
}	

//cau e
double caue(int n){
	int i;
	double S5=0;
	for(i=1; i<=n; i++){
		S5+= 1/(i*(i+1));
	}
	return S5;
}

//cau f
double cauf(int n){
	int i;
	double S6=0;
	for(i=1; i<=n; i++){
		S6+=pow(-1, i)/i;
	}
	return S6;
}
