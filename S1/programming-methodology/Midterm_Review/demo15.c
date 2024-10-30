#include <stdio.h>
#include <math.h>
long Rev(long n);
long Per(long n);
long Pa(long n);
long Pri(long n);
long Arm(long n);
int main(){
	long i , n, per;
	i = 0;
	do{
		printf("Enter n: ");
		scanf("%d", &n);
		i++;
		if(i>5) return 0;
	} while(n<=0 && printf("n>0\n") && i<5);
	
	printf("caua\n");
	printf("Reverse of %ld: %ld", n, Rev(n));
	printf("\ncaub\n");
	Per(n);
	printf("\ncauc\n");
	Pa(n);
	printf("\ncaud\n");
	Pri(n);
	printf("\ncaue\n");
	Arm(n);
}
//caua
long Rev(long n){
	long rev = 0 ;
	long a = n;
	while(a>0){
		rev = rev * 10 + a%10;
		a/=10;
	}
	return rev;
}
//caub
long Per(long n){
	long per=0;
	int i;
	for(i=1; i<n; i++){
		if(n%i==0)
			per+=i;
	}
	if(per==n)
		printf("%ld is perfect number", n);
	else
		printf("%ld isn't perfect number", n);
}
//cauc 
long Pa(long n){
	long rev=0;
	long a = n;
	while(a>0){
		rev = rev*10 + a%10;
		a/=10;
	}
	if(rev==n)
		printf("%ld is palindrome number", n);
	else
		printf("%ld isn't palindrome number", n);
}

//caud
long Pri(long n){
	int i, flag=0;
	for(i=2; i<=n; i++){
		if(n%i==0)
			flag=1;
			break;
	}
	if(flag==0)
		printf("%ld is prime number", n);
	else
		for(i=1; i<n; i++){
			printf("%d\t", i);
		}
}

//caue 
long Arm(long n){
	int i, a, socuoi;
	long sum=0;
	long num = n;
	a = log10(n)+1;
	for(i=1; n; i++){
		socuoi=n%10;
		sum+=pow(socuoi, a);
		n/=10;
	}
	if(sum==num)
		printf("%ld is Armstrong number", num);
	else
		printf("%ld isn't Armstrong number", num);	
}
