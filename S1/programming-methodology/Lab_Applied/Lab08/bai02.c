#include<stdio.h>
#include<string.h>

typedef struct {
	char id[10];
	char name[20];
	char sex[8];
	int bday;
	int bmonth;
	int byear;
	char phonenum[10];
	int salary;
} Employee;

void main(){
    Employee a[10]={{"522H0087","Bao","male",1,9,2004,"001",1000015}
					,{"522H006","Nhan","male",15,2,2004,"002",2000000}
					,{"522H0085","Trung","male",3,9,2004,"003",3000000}
					,{"522H0084","Viet","male",4,9,2004,"004",4000000}
					,{"522H0083","Huy","male",5,9,2004,"005",5000000}
					,{"522H0082","Nghia","male",5,9,2004,"006",6000000}
					,{"522H0081","Phuong","female",7,9,2004,"007",7000000}
					,{"522H0080","Tin","male",8,9,2004,"008",8000000}
					,{"522H0087","Dung","male",9,9,2004,"009",9000000}
					,{"522H0087","Phong","male",10,9,2004,"010",400000}
					};
};
