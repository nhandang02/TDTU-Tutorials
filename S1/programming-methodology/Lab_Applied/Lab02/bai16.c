    #include <stdio.h>
    #include <math.h>

    int main()
    {
        int num, socuoi, v, sum, i, n;

        printf("Enter upper limit: ");
        scanf("%d", &n);

        printf("Armstrong number between 1 to %d are: \n", n);
        while(i<=n)
        {
        	sum = 0;

            num = i;

            v =  log10(num) + 1;
            
            while(num > 0)
            {
                socuoi = num % 10;

                sum = sum + pow(socuoi, v);

                num = num / 10;
            }
            if(i == sum && i!=0 )
            {
                printf("%d, ", i);
            }
            i++;
        }
        
        
        
        printf("\n");
        printf("Armstrong number between 1 to %d are: \n", n);
        int j,N,t;
		
        for(j=1; j<=n; j++)
        {
            sum = 0;

            N = j;

            t =  log10(N) + 1;

            while(N > 0)
            {
                socuoi = N % 10;

                sum = sum + pow(socuoi, t);

                N = N / 10;
            }
            if(j == sum)
            {
                printf("%d, ", j);
            }
        }
        
        
        printf("\n");
        printf("Armstrong number between 1 to %d are: \n", n);
        int x=1, g, h;
        do
        {
        	sum = 0;

            h = x;

            g =  log10(h) + 1;

            while(h > 0)
            {
                socuoi = h % 10;

                sum = sum + pow(socuoi, g);

                h = h / 10;
            }
            if(x == sum)
            {
                printf("%d, ", x);
            }
            x++;
		}
		while(x<=n);
        
		
        return 0;
    }
