#include <stdio.h>

int sesort(int a[], int x)
{

int i, start, min, temp;
for(start = 0; start < x - 1; start++)
{
	min = start;
	for (i = start + 1; i < x; i++)
{
		if (a[i] < a[min]) 
	{
			min = i;
	}
}

temp = a[start];
a[start] = a[min];
a[min] = temp;
}

}

int bubbleSort(int a[], int x)
{

int i, limit, temp;
for (limit = x-2; limit >= 0; limit--)
{
	for (i=0; i <= limit; i++)
	{
		if (a[i] > a[i+1])
		{
			temp = a[i];
			a[i] = a[i+1];
			a[i+1] = temp;
		}
	}
}
}



int main()
{
	int a[100], size, i;
	
	printf("Nhap so phan tu cua mang: ");
	scanf("%d", &size);
	
	 
   	for ( i = 0; i < size; i++)  
    {  
    	printf ("Nhap mang a[%d]: ", i); 
        scanf (" %d", &a[i]); 
    }
    sesort(a, size);
    bubbleSort(a, size)
    for(i = 0; i < size; i++)
    {
    	printf("\n%d", a[i]);
	}
	
return 0; 
}
