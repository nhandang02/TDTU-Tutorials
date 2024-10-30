#include <stdio.h>
int main() {
	int n, flag;
	printf("nhap n: ");
    scanf("%d", &n);
    while (n<2) {
    	printf("nhap n >=2: ");
    	scanf("%d", &n);
	}
	
    return tim(n);			
}

int tim(int n) {
	int flag = 0, i, x;
	for(x=1; x<=n; x++)
    	{
    		int flag = 0;
    		for(i=2; i<=x/2; i++)
    		{
    			if(x%i==0)
    			{
    				flag=1;
    				break;
				}
			}
	    if(flag==0 && x!=1) 
	    printf("%d ", x);
		}
	}
