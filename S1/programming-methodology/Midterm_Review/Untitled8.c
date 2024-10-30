#include <stdio.h>
int main(){
	int n;
	int tiengui = 0;
	printf("Enter hour: ");
	scanf("%d", &n);
	
	if(n>=24){
		tiengui = n / 24 * 200000;
		n = n % 24;
    }
    if(n>0 && n<=2)
		tiengui+= n*10000;
	else if(n>2 && n<=10)
		tiengui+= 20000 + (n-2)*15000;
	else if(n>10 && n<24)
		tiengui+= 20000 + 8*15000 + (n-10)*10000;
	
	printf("Tien gui = %d", tiengui);	
}
