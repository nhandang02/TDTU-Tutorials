#include <stdio.h>
#include <string.h>

typedef struct{
	char MSSV[10];
	char HoVaTen[50];
	char Gioi[10];
	int Namsinh;
	char Mail[50];
	char Khoa[20];
} SinhVien;

void in(SinhVien d){
	printf("%s", d.MSSV);
	printf("%s", d.HoVaTen);
	printf("%s", d.Gioi);
	printf("%d", d.Namsinh);
	printf("%s", d.Mail);
	printf("%s\n", d.Khoa);
	
}

void tuoi(SinhVien a[]){
	int i, n=5, count=0;
	char x[10]={2003};
	for(i=0; i<n; i++){
		if(strcmp(a[i].Namsinh,x)==0){
			count++;
		}
	}
	printf("%d", count);
}

int main(){
	int i;
	SinhVien a[5]={{"522H0006  ","Dang Thanh Nhan  ", "Nam  ", 2004, "  522H0006@studen.tudtu.edu.vn  ", "CNTT" }
				  ,{"522H0005  ","Dang Thanh Nhan  ", "Nam  ", 2005, "  522H0005@studen.tudtu.edu.vn  ", "CNTT" }
				  ,{"522H0004  ","Dang Thanh Nhan  ", "Nam", 2008, "  522H0004@studen.tudtu.edu.vn  ", "CNTT" }
				  ,{"522H0003  ","Dang Thanh Nhan  ", "Nam", 2003, "  522H0003@studen.tudtu.edu.vn  ", "CNTT" }
				  ,{"522H0002  ","Dang Thanh Nhan  ", "Nam", 2002, "  522H0002@studen.tudtu.edu.vn  ", "CNTT" }
				  };
//	for (i=0 ; i<5;i++){
//			in(a[i]);
//	}
}
