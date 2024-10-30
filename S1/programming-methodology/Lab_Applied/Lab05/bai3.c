#include <stdio.h>
#define N 1000
#include <string.h>

int main(){
	char a[100];
	
	printf("Enter your full name: ");
	gets(a);
	
	printf("Your full name is: %s\n", a);
	
    char * token = strtok(a, " ");
    char *firstname = NULL, *lastname = NULL;
    
    while(token != NULL){
    	if(firstname == NULL){
    		firstname = token;
	    }
		else{
			lastname = token;
		}
	token = strtok(NULL, " ");
    }
    printf("firstname: %s\nlastname: %s\n", firstname, lastname);
    return 0;
}
