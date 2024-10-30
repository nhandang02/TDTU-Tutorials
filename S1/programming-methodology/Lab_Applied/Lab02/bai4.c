    #include <stdio.h>
    int main()
    {
    	int S,i,n;
    	S=0;
    	do 
    	{
    		printf("nhap so n: ");
    		scanf("%d", &n);
		}
		while (n<0);
		for(i=1; i<=n; i++)
		{
			S+=i;	
	    }
		printf("tong cac so tu 1 den n = %d", S);
		
		return 0; 
		
		
	}
