    #include <stdio.h>
    int main ()
    {
    	int n, reverse=0;
    	printf("nhap n: ");
    	scanf("%d", &n);
    	while (n<10)
    	{
    		printf("nhap n >= 10: ");
    		scanf("%d", &n);
		}
		while (n!=0)
		{
			reverse = (reverse * 10) + (n % 10);
			n/=10;
		}
		printf("so sau khi dao nguoc la: %d", reverse);
		
		return 0;
	}
