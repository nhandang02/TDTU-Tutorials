    #include <stdio.h>
    int main()
    {
    	int n,i,S;
    	S=0;
    	do
    	{
    		printf("nhap so n: ");
    		scanf("%d", &n);
		}
		while (n<0);
		for(i=1; i<=n; i++)
		{
			if (i % 2 == 0)
			S+=i;
		}
		printf("tong cac so chan tu 1 den n = %d\n",S);
		
		
		do
		{
			if (i%2==0)
			S+=i;
			i+=1; 
		}
		while (i<=n);
		printf("tong cac so chan tu 1 den n = %d\n", S);
		
		
		while (i<=n)
		{
			if (i%2==0)
			S+=i;
			i+=1;
		}
		printf("tong cac so chan tu 1 den n = %d", S);
		
		return 0;
	}
	
