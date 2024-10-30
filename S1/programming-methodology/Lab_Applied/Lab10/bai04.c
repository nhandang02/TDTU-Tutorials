#include <stdio.h>
#include <string.h>

int ktdx(char s[]){
	int i, n=strlen(s);
	for(i=0; i<=n/2; i++){
		if(s[i] != s[n-i-1])
			return 0;
		return 1;
	}
}

int main(){
	char s[10];
	printf("Nhap chuoi: ");
	scanf("%s", &s);
	
	ktdx(s);
	
}
