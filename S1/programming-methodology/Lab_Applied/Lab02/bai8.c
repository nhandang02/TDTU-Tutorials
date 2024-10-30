    #include <stdio.h>
    int main()
    {
    	int n;
    	printf("nhap so n: ");
    	scanf("%d", &n);
    	
		int v;
		for(v=0; n != 0; v++)
		{
			n = n / 10;
		}
		printf("so n co %d chu so", v);
		
		return 0;
	}
