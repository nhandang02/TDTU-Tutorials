#include <stdio.h>
int main(){
	int i, n, max = 0, temp;

	do{
		printf("Nhap so n > 0: ");
		scanf("%d", &n);
	} while(n<0);
	
	temp = n;
	int j;
	for(j=1; j<n; j++){
		i = n % 10;
		if(i>max)
			max = i;
		(n/=10);	
	} 
	printf("So lon nhat trong %d la: %d", temp, max);
	
	return 0;
}
