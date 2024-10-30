#include <stdio.h>
#define N 100

int Sub(int a[N][N], int b[N][N], int sum[N][N], int c, int r, int i, int j){
	for (i = 0; i < r; i++){
		for (j = 0; j < c; j++) {
			sum[i][j] = a[i][j] / b[i][j];
        }	
    }
    
    printf("\nSum of two matrices: \n");
    for (i = 0; i < r; ++i){
    	for (j = 0; j < c; ++j) {
    		printf("%d  ", sum[i][j]);
            if (j == c - 1) {
			    printf("\n\n");
            }
        }
    }
}
int main(){
    int r, c, a[N][N], b[N][N], sum[N][N], i, j;
    printf("Enter the number of rows (between 1 and 100): ");
    scanf("%d", &r);
    printf("Enter the number of columns (between 1 and 100): ");
    scanf("%d", &c);

    printf("\nEnter elements of 1st matrix:\n");
    for (i = 0; i < r; i++){
        for (j = 0; j < c; j++) {
            printf("Enter element a%d%d: ", i + 1, j + 1);
            scanf("%d", &a[i][j]);
        }
    }
    printf("Enter elements of 2nd matrix:\n");
    for (i = 0; i < r; ++i){
        for (j = 0; j < c; ++j) {
            printf("Enter element b%d%d: ", i + 1, j + 1);
            scanf("%d", &b[i][j]);
        }
    }
    return Sub(a, b, sum, c, r, i, j);
}
