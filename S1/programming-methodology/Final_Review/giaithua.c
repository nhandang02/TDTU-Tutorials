#include <stdio.h>
#include <math.h>
int giaithua(int n){
	int i, S=1;
	for(i=2; i<=n; i++){
		S*=i;
	}
	return S;
}
int mu2(int n){
	int i, S=0;
	for(i=1; i<=n; i++){
		S+=(i*i);
	}
	return S;
}
float chia(int n){
	float i; 
	float S=0;
	for(i=2; i<=n; i++){
		S+=(i-1)/i;
	}
	return S;
}

float can2(int n){
	int i;
	float S=0;
	for(i=1; i<=n; i++){
		S+=sqrt(i+1);
	}
	return S;
}

int cauf(int n){
	int i, S=0;
	for(i=0; i<=n; i++){
		S+=pow(1,i);
	}
	return S;
}

float caug(int n){
	int i;
	float S=0;
	for(i=1; i<=n; i++){
		float k=1/2.0;
		S+=3*i-1/2.0;
	}
	return S;
}
	
void main(){
	int n;
	do
	{
	printf("Nhap so n: ");
	scanf("%d", &n);
	}while(n<0);
	
	printf("cau a, S = %d\n", giaithua(n));
	printf("cau b, S = %d\n", mu2(n));
	printf("cau c, S = %f\n", chia(n));
	printf("cau e, S = %f\n", can2(n));
	printf("cau f, S = %d\n", cauf(n));
	printf("cau g, S = %f\n", caug(n));
}
