    #include <stdio.h>
    int main()
    {
    	int x, y, z, n, i, j, k;
    	
    	printf("Enter n: ");
    	scanf("%d", &n);
    	while (n<2)
    	{
    		printf("Enter n >=2: ");
    		scanf("%d", &n);
		}
		
		
		printf("The prime numbers from 1 to %d is: ", n);
    	for(x=1; x<=n; x++)
    	{
    		int flag = 0;
    		for(i=2; i<=n/2; i++)
    		{
    			if(x%i==0)
    			{
    				flag=1;
    				break;
				}
			}
	    if(flag==0 && x!=1) 
	    printf("%d ", x);
		}
		
		printf("\nThe prime numbers from 1 to %d is: ", n);
		while(y <= n)
		{
			int flag = 0;
			for(j=2; j<=n/2; j++)
			{
				if(y%j==0)
				{
				    flag=1;
				    break;
			    }
			}
			if(flag==0 && y!=1)
			{
				printf("%d ", y);
			}
			y++;
		}
		
		
		printf("\nThe prime numbers from 1 to %d is: ", n);
		do
		{
			
			int flag=0;
			for(k=2; k<=n/2; k++)
			{
				if(z%k==0)
				{
				    flag=1;
				    break;
			    }
			}
			
			if(flag==0 && z!=1 && z!=0)
			{
				printf("%d ", z);
			} 
			z++;		
		}
		while(z <= n);
		    
    	return 0;	
	}
