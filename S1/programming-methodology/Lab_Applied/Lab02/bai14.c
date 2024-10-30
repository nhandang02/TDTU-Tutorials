    #include <stdio.h>

    int main()
    {
        int i, n, sum = 0;
	
	    printf("nhap so n: ");
        scanf("%d", &n);
        while(n<0)
        {
        	printf("nhap so n>0 : ");
        	scanf("%d", &n);
		}
		
		
        for(i = 1; i <= n / 2; i++)
        {
            if(n%i == 0)
            {
                sum += i;
            }
        }
        
    
        if(sum == n && n > 0)
        {
            printf("%d is PERFECT NUMBER", n);
        }
        else
        {
            printf("%d is NOT PERFECT NUMBER", n);
        }
        
        
    return 0;
    }
