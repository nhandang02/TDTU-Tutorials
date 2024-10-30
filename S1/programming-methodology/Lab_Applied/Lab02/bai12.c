    #include <stdio.h>
    int main()
    {
    	int n, i, flag = 0;
    	printf("nhap n: ");
    	scanf("%d", &n);
    	while (n<2)
    	{
    		printf("nhap n >=2: ");
    		scanf("%d", &n);
		}
	
		
		return tim1(n) ;
	}
	int tim1(int n) {
		int i, flag = 0;
		for (i=2; i <= n/2; i++)
		{
			if(n % i == 0)
			{
				flag = 1;
				break;
			}
		}
		if(flag == 0)
		{
			printf("%d is a prime number", n);
		}
		else
		{
			printf("%d isn't a prime number", n);
		}
	}
