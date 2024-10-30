#include <stdio.h>
#include <math.h>

//giaithua
int Fac(int n){
	if(n>=1)
		return Fac(n-1)*n;
	else
		return 1;
	}

//caua
int cauA(int n, int i){
	if(i>n)
		return 0;
	else
		return cauA(n, i+1) + (2*i+1);
}

//caub
double cauB(int n, int i){
	if(i>n)
		return 0;
	else 
		return cauB(n, i+1) + i/2.0 ;
}

//cauc
int cauC(int n, int i){
	if(i>n)
		return 0;
	else 
		return cauC(n, i+1) + Fac(i);
}

//caud
double cauD(int n, int i){
	if(i>n)
		return 0;
	else 
		return cauD(n, i+1) + sqrt(i);
}

//caue
double cauE(int n, int i){
	if(i>n)
		return 1;
	else 
		return cauE(n, i+1) * Fac(i);
}

int main(){
	int n;
	int i=1;
	
	printf("Enter a number: ");
	scanf("%d", &n);
	
	printf("Cau A = %d\n", cauA(n, i));
	printf("Cau B = %.2lf\n", cauB(n, i));
	printf("Cau C = %d\n", cauC(n, i));
	printf("Cau D = %.1lf\n", cauD(n, i));
	printf("Cau E = %.2lf", cauE(n, i));
	
	return 0;
}

