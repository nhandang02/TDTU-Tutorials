#include <stdio.h>

int main() {
	long m;
	int n, t, d;
	
	printf("1.Tra Xanh-14000\n2.Sting-12000\n3.Pepsi-10000\n4.Warrior-16000\n5.Nuoc Suoi-6000\n6.Sua tuoi-8000\n"); 
	printf("Chose one from 1 to 6: ");
	scanf("%d", &n);
	if (n>0 && n<7) {
		t = 0;
		d = 0;
		switch (n) {
			case 1:
				printf("Enter money: ");
				scanf("%ld", &m);
				
				if (m>14000 && m%2000==0) {
					t = m/14000;
					d = m - 14000*t;
					printf("Tra xanh - %d chai - Tien du %d", t, d);
					break;
				} else {
					printf("Nhap sai");
					break;
				}
			case 2:
				printf("Enter money: ");
				scanf("%ld", &m);
				
				if (m>12000 && m%2000==0) {
					t = m/12000;
					d = m - 12000*t;
					printf("Sting - %d chai - Tien du %d", t, d);
					break;
				} else {
					printf("Nhap sai");
					break;
				}
			case 3:
				printf("Enter money: ");
				scanf("%ld", &m);
				
				if (m>10000 && m%2000==0) {
					t = m/10000;
					d = m - 10000*t;
					printf("Pepsi - %d chai - Tien du %d", t, d);
					break;
				} else {
					printf("Nhap sai");
					break;
				}
			case 4:
				printf("Enter money: ");
				scanf("%ld", &m);
				
				if (m>16000 && m%2000==0) {
					t = m/16000;
					d = m - 16000*t;
					printf("Warrior - %d chai - Tien du %d", t, d);
					break;
				} else {
					printf("Nhap sai");
					break;
				}
			case 5:
				printf("Enter money: ");
				scanf("%ld", &m);
				
				if (m>6000 && m%1000==0) {
					t = m/6000;
					d = m - 6000*t;
					printf("Nuoc suoi - %d chai - Tien du %d", t, d);
					break;
				} else {
					printf("Nhap sai");
					break;
				}
			case 6:
				printf("Enter money: ");
				scanf("%ld", &m);
				
				if (m>8000 && m%1000==0) {
					t = m/8000;
					d = m - 8000*t;
					printf("Sua tuoi - %d hop - Tien du %d", t, d);
					break;
				} else {
					printf("Nhap sai");
					break;
				}
		}
	} else printf("Nhap sai!");
	return 0;
}	
