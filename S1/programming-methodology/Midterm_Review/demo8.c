#include <stdio.h>
int main()
{
	int i, x = 0;
    printf("Nhap so tien: ");
    scanf("%d", &x);
 
    int soto_500 = 0;
    int soto_100 = 0;
    int soto_50 = 0;
    int soto_20 = 0;
    int soto_10 = 0;
	
	if (x % 10000 == 0){
    	for ( i = 1; i > 0; i++ )
    	{
        	if (x >= 500000)
        	{
            	x -= 500000;
            	soto_500++;
        	}
        	else if ((x < 500000) && (x >= 100000))
        	{
            	x -= 100000;
            	soto_100++;
        	}
        	else if ((x < 100000) && (x >= 50000))
        	{
           		x -= 50000;
            	soto_50++;
        	}
        	else if ((x < 50000) && (x >= 20000))
        	{
            	x -= 20000;
            	soto_20++;
        	}
        	else if (x == 10000)
        	{
            	x -= 10000;
            	soto_10++;
        	}
        	else if (x == 0)
        	{
            	break;
        	}
    	}
    		printf("%d to 500000\n", soto_500);
    		printf("%d to 100000\n", soto_100);
    		printf("%d to 50000\n", soto_50);
    		printf("%d to 20000\n", soto_20);
    		printf("%d to 10000\n", soto_10);
    }
 	else{
 	 	printf("Nhap sai du lieu");
	}
    return 0;
}

