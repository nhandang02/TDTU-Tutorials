#include <stdio.h>
#include <string.h>
void noichuoi(char x1[], char x2[]);
int main(){
    char x1[100];
    char x2[100];
    printf("Nhap vao chuoi x1: ");
    gets(x1);
    printf("Nhap vao chuoi x2: ");
    gets(x2);
    printf("\nChuoi vua nhap la: \nx1 = %s\nx2 = %s", x1,x2);
    noichuoi(x1,x2);
    printf("\nChuoi sau khi noi la: %s", x1);
}
void noichuoi(char x1[], char x2[]){
    int j=0, i;
    for(i=strlen(x1); i<(strlen(x1)+strlen(x2)); i++){
        x1[i]=x2[j];
        j++;
    }
    x1[i]='0/';
}

