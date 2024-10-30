#include <stdio.h>
#include <string.h>

int main(){
	char a[100];
	char b[100];
	
	printf("Enter tring 1: ");
	gets(a);
	
	printf("Enter string 2: ");
	gets(b);
	
	char *ret;

   	ret = strpbrk(a, b);
    printf("First position s2 appear in s1 is: %c\n", *ret);
   
   	return(0);
}
