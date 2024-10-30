	if(strcmp(w, "Rain") == 0){
		fo = fopen("output.out","w");	
		bcbg = n / (nc+ng);
		nd1 = n - bcbg*(nc+ng);
		bc = bg = bcbg;
		if(bcbg>0)
		{
			while(nd1>=nc || nd1>=ng)
			{
				if(bc+bg<=ld && nd>=0)
				{
					if(nc>ng)
					{
						bc+=(int)nd1/nc;
						nd = nd1 - (int)(nd1/nc)*nc;
						bg+=(int)(nd/ng)*ng;
						nd-=(int)(nd/ng)*ng;
					}
					else
					{
						bg+=(int)nd1/ng;
						nd = nd1 - (int)(nd1/ng)*ng;
						bc+=(int)(nd/nc)*nc;
						nd-=(int)(nd/nc)*nc;
					}
				}
				else break;
			}		
		}
		else
		{	
			while(bc+bg<=ld && nd>=0)
			{	
				if(nc>ng)
				{
					bc = n / nc;
					nd = n - bc*nc;
					bg = nd / ng;
					nd = nd - bg*ng;
				}
				else
				{
					bg = n / ng;
					nd = n - bg*ng;
					bc = nd / nc;
					nd = nd - bc*nc;	
				}
			}
		}
		fprintf(fo ,"%d %d %.3f" ,bc ,bg ,nd);
		fclose(fo);
	}
