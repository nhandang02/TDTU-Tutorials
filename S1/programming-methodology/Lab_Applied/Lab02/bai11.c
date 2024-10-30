    #include <stdio.h>
    int main()
    {
    	int n, num; 
		int reverse=0; 
    	printf("nhap n: ");
    	scanf("%d", &n);
    	while (n<10)
    	{
    		printf("nhap n >= 10: ");
    		scanf("%d", &n);
		}
		num = n;
		while (n!=0)
		{
			reverse = (reverse * 10) + (n%10);
			n/=10;
		}
		if(reverse == num)
		{
	        printf("%d is palindrome", reverse);
		}
		else
		{
			printf("%d isn't palindrome", reverse);
		}
	
		return 0;
	}
