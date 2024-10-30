#include <stdio.h>
int main()
{
	int a, nam, tuan, ngaydu;
	
	printf("so ngay =");
	scanf("%d", &a );
	
	nam= a / 365;
    tuan= a / 7;
	ngaydu= a % 7;
	
	printf("nam= %d\n", nam);
	printf("tuan= %d\n", tuan);
	printf("ngaydu= %d", ngaydu);
	return 0;
}
