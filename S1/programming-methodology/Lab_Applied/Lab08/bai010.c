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

void print(Employee d){
	printf("%s",d.id);
	printf("  %s",d.name);
	printf("  %s",d.sex);
	printf("  %d",d.bday);
	printf("  %d",d.bmonth);
	printf("  %d",d.byear);
	printf("  %s",d.phonenum);
	printf("  %d\n",d.salary);
}
void write(Employee a[],int n){
	int i;
	for(i=0;i<n;i++)
		print(a[i]);
}
void srch_dele(Employee a[],int n, char id[]){
	int i,j;
	for(i=0;i<n;i++)
		if (strcmp(a[i].id,id)==0){
			for (j=i;j<n;j++) a[j]=a[j+1];
			n--;
		} 
	write(a,n);	
}
void main(){
	int i;
	char id[10];
	Employee a[10]={{"522H0087","Bao   ","male  ",1,9,2004,"001",100001}
					,{"522H0086","Nhan  ","male  ",2,9,2002,"002",200000}
					,{"522H0085","Trung ","male  ",3,9,2005,"003",300000}
					,{"522H0087","Viet  ","male  ",4,9,2009,"004",400000}
					,{"522H0083","Huy   ","male  ",5,9,2004,"005",500000}
					,{"522H0082","Nghia ","male  ",5,9,2006,"006",600000}
					,{"522H0081","Phuong","female",7,9,2007,"007",700000}
					,{"522H0080","vy    ","female",8,9,2002,"008",800000}
					,{"522H0079","Dung  ","male  ",9,9,2004,"009",900000}
					,{"522H0078","Ngoc  ","female",10,9,2003,"010",1000000}
					};
	printf("Enter id number want to delete: ");
	scanf("%s",&id);
	srch_dele(a,10,id);
};
