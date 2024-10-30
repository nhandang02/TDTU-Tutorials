#include <stdio.h>
#include <string.h>

//int main(){
//	int i=1, s=0, n=36;
//	while(i<=n){
//		if(n%i==0){
//			s+=n%i;
//		}
//		i++;
//	}
//	printf("%d", s);
//	return 0;
//}

//int main(){
//	const int x=5;
//	const int *ptrx;
//	ptrx = &x;
//	ptrx = 10;
//	printf("%d\n", x);
//	return 0;
//}

int main(){
	char s[100];
	printf("Nhap chuoi:");
	fgets(s,100,stdin);
	printf("%s", strlwr  (s));
}
