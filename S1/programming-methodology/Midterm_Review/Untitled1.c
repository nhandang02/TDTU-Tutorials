#include <stdio.h>
int Max(int A[], int n)
{
	if (n == 0)
		return -1;
	if (n == 1)
		return A[0];
	else
	{
		if (A[n - 1] > Max(A, n - 1))
			return A[n - 1];
		else
			return Max(A, n - 1);
	}
}
void main()
{
	int n=10 ;
	int A[10] = { 4, 6, 3, 19, 22, 34, 67, 54, 15, 24 };
	printf("Gia Tri Lon Nhat Cua Mang: %d\n", Max(A, 2));
}
