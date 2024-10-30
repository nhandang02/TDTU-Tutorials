#include <stdio.h>
void UC(int h, int n);
void UCLN(int h, int n);
void Ami(int h, int n);
int main(){
	int h, n;
	
	printf("Enter h: ");
	scanf("%d", &h);
	
	printf("Enter n: ");
	scanf("%d", &n);
	while(n<0 || h<0){
		printf("Enter h > 0: ");
		scanf("%d", &h);
		printf("Enter n > 0: ");
		scanf("%d", &n); 		
	}
	printf("\ncaua\n");
	UC(h, n);
	printf("\ncaub\n");
	UCLN(h, n);
	printf("\ncaud\n");
	Ami(h, n); 
}
//caua
void UC(int h, int n){
	int i;
	if(h<n){
		for(i=1; i<=h; i++){
			if(h%i==0 && n%i==0)
				printf("%d\t", i);
		}
	}
	else{
		for(i=1; i<=n; i++){
			if(h%i==0 && n%i==0)
				printf("%d\t", i);
		}
	}
}
//caub
void UCLN(int h, int n){
	int x, y;
	x=h;
	y=n;
	while(x!=y){
		if(x>y)
			x-=y;
		else
			y-=x;
	}
	printf("UCLN: %d", x);
	printf("\ncauc\n");
	printf("BCNN: %d", (h*n)/x);
}
//caud
void Ami(int h, int n){
	int i, sh=0, sn=0;
	for(i=1; i<h; i++){
		if(h%i==0)
			sh+=i;
	}
	for(i=1; i<n; i++){
		if(n%i==0)
			sn+=i;
	}
	if(sh==n && sn==h){
		printf("%d, %d is Amicable numbers", h, n);
	}
	else
		printf("%d, %d isn't Amicable numbers", h, n);
}

