#include <stdio.h>

int main(){
	int n, t, d;
	long m;
	
	printf("Choose one from 1 to 6: ");
	scanf("%d", &n);
	
	if(n>0 && n<7){
		t = 0;
		d = 0;
		
		switch(n){
			case 1:
				printf("Enter money: ");
				scanf("%d", &m);
				
				if(m>14000 && m % 2 ==0){
					t = m / 14000;
					d = m - t*14000;
					printf("Tra xanh - %d chai - %d tien du", t, d);
					break;
				}
				else printf("Nhap sai");
			case 2:
				printf("Enter money: ");
				scanf("%d", &m);
				
				if(m>12000 && m % 2 ==0){
					t = m / 12000;
					d = m - t*12000;
					printf("Sting - %d chai - %d tien du", t, d);
					break;
				}
				else printf("Nhap sai");
			case 3:
				printf("Enter money: ");
				scanf("%d", &m);
				
				if(m>10000 && m % 2 ==0){
					t = m / 10000;
					d = m - t*12000;
					printf("Pepsi - %d chai - %d tien du", t, d);
					break;
				}
				else printf("Nhap sai");
			case 4:
				printf("Enter money: ");
				scanf("%d", &m);
				
				if(m>16000 && m % 2000 == 0){
					t = m / 16000;
					d = m - t*16000;
					printf("Warrior - %d chai - %d tien du", t, d);
					break;
				}
				else 
					printf("Nhap sai");
			case 5:
				printf("Enter money: ");
				scanf("%d", &m);
				
				if(m>6000 && m % 2000 == 0){
					t = m / 6000;
					d = m - t*6000;
					printf("Nuoc Suoi - %d chai - %d tien du", t, d);
					break;
				}
				else 
					printf("Nhap sai");
			case 6:
				printf("Enter money: ");
				scanf("%d", &m);
				
				if(m>8000 && m % 2000 == 0){
					t = m / 8000;
					d = m - t*8000;
					printf("Sua Tuoi - %d chai - %d tien du", t, d);
					break;
				}
				else 
					printf("Nhap sai");
		}
	}
	else
		printf("Nhap sai");
		
	return 0;
}
