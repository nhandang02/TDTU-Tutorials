#include <stdio.h>
int UCLN1(int a, int b){
	while(a!=b)
	{
		if(a>b)
		a-=b;
		else
		b-=a;
	}
	return a;
}
	
int UCLN2(int a, int b){
	while(a*b!=0){
		if(a>b) a%=b;
		else b%=a;
	}
	return a+b;
}

int BCNN(int a, int b){
	int i, start, bcnn;
	if(a>b) start=a;
	else start=b;
	int max=a*b;
	for(i=start; i<=max; i+=start){
		if(i%a==0 && i%b==0){
			bcnn=i;
		}
	}
	return bcnn;
}

int Tong3(int n){
	int i, S=0;
	for(i=0; i<=n; i++){
		if(i%3==0) S+=i;
	}
	return S;
}

int Tong2(int n){
	int i, S=0;
	for(i=0; i<=n; i++){
		if(i%2==0) S+=i;
	}
	return S;
}

float TBC(int n){
	int j, i; 
	float S=0;
	for(i=0; n!=0; i++){
		S+=n%10;
		n/=10;
		j++;	
	}
	return S/j;
}

int DX(int n){
	int i, S=0;
	int a=n;
	for(i=0; n!=0; i++){
		S = S*10 + n%10;
		n/=10;
	}
	if(a==S)
	{
		printf(" %d la so doi xung", a);
	}
	else
	{
		printf(" %d ko la so doi xung", a);
	}
}


int Max(int n){
	int a, i, max;
	max=n%10;
	for(i=0; n!=0; i++){
		a=n%10;
		if(a>max) max=a;
		n/=10;
	}
	return max;
}


int Per(int n){
	int S=0;
	int flag=0;
	int i;
	for(i=1; i<n; i++){
		if(n%i==0)
			S+=i;
	}
	if(S==n) flag=1;
	return flag;
}


int Check(int n){
	int i, a, flag=1;
	for(i=0; n!=0; i++){
		a=n%10;
		if(a%2!=0)
		{
			flag=0;
			break;
		}
		n/=10;
	}
	return flag;
}
int main(){
	int a, b, n;
//	printf("Nhap so a: ");
//	scanf("%d", &a);
//	printf("Nhap so b: ");
//	scanf("%d", &b);

	printf("Nhap so n: ");
	scanf("%d", &n);
	
	
//	printf("Cau a: UCLN1 = %d\n", UCLN1(a,b));
//	printf("Cau b: UCLN2 = %d\n", UCLN2(a,b));
//	printf("Cau 3: BCNN = %d\n", BCNN(a,b));
//	printf("Cau 4: S = %d\n", Tong3(n));
//	printf("Cau 5: S = %d\n", Tong2(n));
//	printf("Cau 6: S = %f\n", TBC(n));
//	printf("Cau 7:");  DX(n); printf("\n");
//	printf("Cau 8: So lon nhat trong day so n la: %d\n", Max(n));
//	printf("Cau 9: kiem tra so hoan thien: %d", Per(n)); 
	printf("Cau 10: kiem tra so chan: %d", Check(n)); 
}
