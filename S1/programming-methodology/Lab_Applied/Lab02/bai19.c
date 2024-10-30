    #include <stdio.h>
    int main()
    {
    	int n,i,P;
        P=1;
    	
    	printf("nhap so n can tinh giai thua: ");
    	scanf("%d", &n);
    	
    	 while(n<1)
    	{
    		printf("nhap so n >= 1 ");
    		scanf("%d", &n);
		}
		
    	
		for(i=1; i<=n; i++)
		{
			P*=i;
		}
		
		printf("giai thua cua so %d la: %d", n, P);
		
		return 0;
	}
