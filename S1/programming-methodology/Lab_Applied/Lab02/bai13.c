    #include <stdio.h>
    #include <math.h>
    int main()
    {
    	int n, socuoi, num, sum, v;
    	sum=0;
    	num=n;
    	
    	printf("nhap so n: ");
    	scanf("%d", &n);
    	while (n<10)
    	{
    		printf("nhap so n >= 10:");
    		scanf("%d", &n);
		}
		
		v= log10(n)+1;
		num=n;
		while (n>0)
		{
			socuoi = n % 10;
			sum = sum + pow(socuoi,v);
			n = n / 10;
		}
		if(sum==num)
		{ 
		    printf("%d is armstrong number", num);
		}
		else
		{
			printf("%d isn't armstrong number", num);
		}
		
		return 0;
    }
		
		
	
