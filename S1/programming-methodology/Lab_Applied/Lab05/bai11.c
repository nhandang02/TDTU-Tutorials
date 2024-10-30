#include <stdio.h>
#include <string.h>
void rem(char *s, int n, int p);
int main(){
	char a[100];
	int p, n;
	
	printf("Enter tring: ");
	gets(a);
	
	printf("Enter position: ");
	scanf("%d", &p);
	
	printf("Enter an integer: ");
	scanf("%d", &n);
	
	rem(a, n, p);
	
	return 0;
}
void rem(char *s, int n , int p) {

    int i;
    
    if(n!=0 && p!=1){
    	for (i = 0; i < p - 1; i++) {
        	printf("%c", s[i]);
    	}
    	for (i = p+n; i < strlen(s); i++) {
        	printf("%c", s[i]);
    	}
	}
}
