#include <ctype.h>
#include <string.h>
void check(char a[100]);
int main(){
	char a[100];
	
	printf("Enter your string: ");
	gets(a);
	
	check(a);
}

void check(char a[100]){
	int i;
	for(i=0; i<strlen(a); i++){
		if( isalpha(a[i])){
			printf("%c", a[0]);
			break;
		}
	}
}
