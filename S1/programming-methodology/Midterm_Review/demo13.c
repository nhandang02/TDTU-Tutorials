#include <stdio.h>

int main(){
	int a1, a2, a3, a4;
	float DTB;
	printf("Enter process 1 score: ");
	scanf("%d", &a1);
	printf("Enter process 2 score: ");
	scanf("%d", &a2);
	printf("Enter midterm score: ");
	scanf("%d", &a3);
	printf("Enter endterm score: ");
	scanf("%d", &a4);
	
	DTB = (a1*0.1) + (a2*0.2) + (a3*0.2) + (a4*0.5);
	
	if(a1>=0 && a1<=10 && a2>=0 && a2<=10 && a3>=0 && a3<=10 && a4>=0 && a4<=10){
		if(DTB < 5)
			printf("Diem trung binh: %.2f - Xep loai: Hoc lai", DTB);
		else if(5<=DTB && DTB < 6.5)
			printf("Diem trung binh: %.2f - Xep loai: Trung Binh", DTB);
		else if(6.5<=DTB && DTB < 8)
			printf("Diem trung binh: %.2f - Xep loai: Kha", DTB);
		else if(8<=DTB && DTB < 9)
			printf("Diem trung binh: %.2f - Xep loai: Gioi", DTB);
		else
			printf("Diem trung binh: %.2f - Xep loai: Xuat Sac", DTB);
	}
	else
		printf("Nhap sai");
}
