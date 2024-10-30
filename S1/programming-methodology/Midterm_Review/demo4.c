#include <stdio.h>
#include <math.h>
int main(){
	int a, b, c, P;
	float dientich;
	int chuvi;
	
	printf("Nhap 3 canh cua tam giac: ");
	scanf("%d%d%d", &a, &b, &c);
	
	if(a+b>c && b+c>a && c+a>b && a>0 && b>0 && c>0){
		chuvi = a + b + c;
		P=chuvi*1.0/2;
		dientich = sqrt(P*(P-a)*(P-b)*(P-c));
		if(a==b && b!=c || b==c && c!=a || a==c && c!=b)	
			printf("3 canh tao nen 1 tam giac can");
		else if (a==b && b==c)
			printf("3 canh tao nen 1 tam giac deu");
		else 
			printf("3 canh tao nen 1 tam giac thuong");
		printf("\n");
		printf("Chu vi va Dien tich tam giac la: %d va %.2f", chuvi, dientich);
	}
	else 
		printf("Chuong trinh xay ra loi");					
}
