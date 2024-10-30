    #include <stdio.h>
    int main()
    {
    	int n;
    	printf("nhap n: ");
    	scanf("%d", &n);
    	while (n<10)
    	{
    		printf("nhap so n >= 10: ");
    		scanf("%d", &n);
		}
		long m = n;
		int sum = 0;
		while (m != 0)
		{
			sum+=(m%10);
	        m = m / 10;
		}
		printf("tong cac chu so = %d ", sum);
    	
    	return 0;
	}
