#include<stdio.h>
int table(int c, int l) {
	int i;
	int j;
	printf("table:\n");
	for (i=1; i<=l; i++) {
		for (j=1;j<=c;j++)
			printf("%3d", c*(i-1)+j);
			printf("\n"); }
 	return table; }
int main() {
	int line;
	int column;
	int i;
	int j;
	printf("nhap vao so dong: ");
	scanf("%d", &line);
	printf("nhap vao so cot: ");
	scanf("%d", &column);
	
	table(column, line);
	return 0;
}
