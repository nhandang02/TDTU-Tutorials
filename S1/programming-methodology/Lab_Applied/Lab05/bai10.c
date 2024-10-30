#include <stdio.h>
#include <string.h>
void insert(char a[100], char b[100], int pos);
int main(){
	char a[100];
	char b[100];
	int pos;
	
	printf("Enter tring 1: ");
	gets(a);
	
	printf("Enter string 2: ");
	gets(b);
	
	printf("Enter position: ");
	scanf("%d", &pos);
	
	insert(a, b, pos);
}

void insert(char a[100], char b[100], int pos){
	char c[100];
	strcpy(c, a+pos-1);
    strcpy(a+pos-1, b);
    strcat(a+pos-1, c);
    puts(a);
}
