    #include <stdio.h>
    int main()
    {
    	int n;
    	printf("nhap n: ");
    	scanf("%d", &n);
    	while (n<10)
    	{
    		printf("nhap n >= 10: ");
    		scanf("%d", &n);
		}
		int socuoi = n%10;
		while (n>10)
		{
			n = n / 10;
		}
		printf("so dau: %d\nso cuoi: %d", n, socuoi);
		
		return 0;
	}
