#include <stdio.h> 
#define N 100

int main(){
	char str[N];
	
	printf("Enter your string: ");
	fgets(str, N, stdin);
	
	printf("%s", str);
}
