#include <stdio.h> 
#include <string.h>
#define N 100
void Inhoachudau(char a[]){
	int i;
    for(i=0; i<strlen(a); i++){
        if(i==0|| (i>0 && a[i-1]==' ')){
            if(a[i]>='a' && a[i]<='z')
                a[i]=a[i]-32;    
        }
		else{
            if(a[i]>='A' && a[i]<='Z'){
                a[i]=a[i]+32;    
            }   
        }
    }
}
int main(){ 
    char a[N];
    printf("Nhap vao chuoi ky tu: "); 
    fgets(a, N, stdin);
    printf("\nChuoi vua nhap la: %s", a);
    Inhoachudau(a);
    printf("\nChuoi sau khi doi la: %s", a);
}
