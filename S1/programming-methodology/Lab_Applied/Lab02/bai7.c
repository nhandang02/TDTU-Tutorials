    #include <stdio.h>
    int main()
    {
    	int n;
    	printf("nhap n: ");
    	scanf("%d", &n);
    	while(n<10)
    	{
    		printf("nhap n >= 10: ");
    		scanf("%d", &n);
		}
		long P=1;
		while (n!=0)
		{
			P*=(n%10);
			n = n / 10;
		}
		printf("tich cac so = %ld", P);
		
		return 0; 
	}
