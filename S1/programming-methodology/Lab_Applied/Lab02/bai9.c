    #include <stdio.h>
    #include <math.h>
    int main()
    {
    	int n, a, b, c, d, socuoi, sodau, Swapnum;
    	printf("nhap n: ");
    	scanf("%d",  &n);
    	while (n<10)
    	{
    		printf("nhap n >= 10: ");
    		scanf("%d", &n);
		}
		a= log10(n);
		socuoi= n % 10;
		
		b= sodau * pow(10,a);
		c= n % b;
		d= c / 10;
		
    int sodau1(int n) {
    	int sodau;
    	do {
    		n = n / 10;
		} while(n > 10);
		return n;
	}	
		n = sodau1(n);
		
		
		Swapnum= ((socuoi * pow(10,a)) + (d *10 + sodau));
		
		printf("so sau khi da thay doi so dau va so cuoi la: %d", Swapnum);
		
		
	}	
