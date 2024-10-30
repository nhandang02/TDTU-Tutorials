#include <stdio.h>
#include <string.h>
#include <ctype.h>
void check(char a[100]);
int main(){
	char a[100];
	
	printf("Enter your tring: ");
	gets(a);
	
	check(a);
}

void check(char a[100]){
	int i;
	
	for(i=0; i<strlen(a); i++){
		if( isalnum(a[i]) || isspace(a)[i] ){
			printf("%c", a[i]);
		}
	}
}
