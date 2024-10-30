    #include <stdio.h>
    int main()
    {
    	int n,i, j, k, x, y, z;
		int sum, sum1, sum2;
		
		printf("Enter the number: ");
		scanf("%d", &n);
		
		while(n<0)
		{
			printf("Enter the number > 0: ");
			scanf("%d", &n);
	    }
	    
	    printf("All Perfect numbers between 1 to %d: ", n);
	    for (i=1; i<=n; i++)
		{
		    sum = 0;
		    for (x=1; x<i; x++)
			{
			    if (i%x == 0)
				{
				    sum += x;
			    }	
		    }
		    if (sum == i) {
			    printf("%d ", i);
		    }
	    }
		
		
		printf("\n");
		printf("All Perfect numbers between 1 to %d: ", n);
		j = 1;
	    while (j<=n) 
		{
		    sum1 = 0;
		    y = 1;
		    while (y<j)
			{
		 	    if (j%y == 0) 
				{
				    sum1 += y;
			    }	
			    y++;
		    }
		    if (sum1 == j) 
			{
			    printf("%d ", j);
		    }
		    j++;
	    }
	
	
	
	    printf("\n");
        printf("All Perfect numbers between 1 to %d: ", n);	
		k = 2;
	    do 
		{
		    sum2 = 0;
		    z = 1;
		    do 
			{
			    if (k%z == 0) 
				{
				    sum2 += z;
			    }
			    z++;	
		    } 
			while (z<k);
		    if (sum2 == k) 
			{
			    printf("%d ", k);
		    }
	 	    k++;
	    } 
		while (k<=n);
		
		return 0;
	}
