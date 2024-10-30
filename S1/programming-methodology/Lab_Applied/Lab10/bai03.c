#include <stdio.h>

int nam(int nam){
	if(nam%400==0 || (nam%4==0 && nam%100!=0)) return true;
	else return false;
}
int thang(int thang){
	if((thang<=12) && (thang==1 || thang==3 || thang==5 || thang==7 || thang==9 || thang==12 ||)) return 1;
	else if((thang<=12) && (thang==4 || thang==6 || thang==8 || thang==10)) return 2;
	else if((thang<=12) && (thang==2)) return 3;
	else return 0;
}
int ngay(int ngay){
	if((thang(thang)==1) && ngay<=31 ) return true;
	else if((thang(thang)==2) && ngay<=30 ) return true;
	else if((thang(thang)==3) && nam(nam)==true && ngay<=29) return true;
	else if((thang(thang)==3) && nam(nam)==false && ngay<=28) return true;
	else return false;
}

int main(){
	int ngay, thang, nam;
	
	printf("Nhap ngay: ");
	scanf("%d", &ngay);
	printf("Nhap thang: ");
	scanf("%d", &thang);
	printf("Nhap nam: ");
	scanf("%d", &nam);
	
	
}
