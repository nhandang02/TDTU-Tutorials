#include <stdio.h>
#include <string.h>
#include <math.h>
#define PI 3.1415926535


int sum(int x){
	int i,s,t;
	t=(int) sqrt(x);
	for (i=1;i<=t;i++){
		if (x%i==0){
			s+=i+x/i;
		}
	}
	s-=x;
	if (t*t==x) s-=t;
	return s;
}
int frnum(int n,int ld){
	if (sum(n)==sum(ld))
		return 0;
	else return 1;
}

void main(){
	int n, dc, dg, ld, bc=0, bg=0 ,i,j,l, bcbg;
	double nd, nd1, nd2;
	char w[10];
	FILE *fi,*fo;
	fi = fopen("input.inp", "r");
	
	fscanf(fi, "%d %d %d %d %s", &n, &dc, &dg, &ld, w);
	fclose(fi);
	
	if(n<0 || n>1001 || dc<0 || dg<0 || ld<0 ||ld>300)
	{	
		fo = fopen("output.out","w");
		fprintf(fo,"-1 -1 %d",n);	
		fclose(fo);
	}
	else{
		int nc=dc*dc;
		float ng=(dg*dg*PI)/4;
		
		int mbc=n/nc, mbg=(int) n/ng;
		float min=n;
		
		
		if(strcmp(w, "Wind") == 0){
			
			fo = fopen("output.out","w");
			
			for (i=mbc ; i>=0 ; i--){    
			                  
				for (j=0 ; j<=mbg ; j++){    
				            
					if (i+j<=ld){
						
						nd=n - i*nc - j*ng;	
									
						if (nd>=0){
							if (nd<min){
								min=nd;
								bc=i;
								bg=j;	
							}
						}
						else break;
					}
					else break;
				}
			}
			fprintf(fo ,"%d %d %.3f" ,bc ,bg ,min);
			fclose(fo);	
		}
		
		
		if(strcmp(w, "Rain") == 0){
		fo = fopen("output.out","w");	
		bcbg = n / (nc+ng);
		nd1 = n - bcbg*(nc+ng);
		bc = bg = bcbg;
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
		
		fprintf(fo ,"%d %d %.3f" ,bc ,bg ,nd);
		fclose(fo);
	}
		
		if(strcmp(w, "Cloud") == 0){				
			fo = fopen("output.out","w");
			
			if (frnum(n,ld)==0)
				fprintf(fo ,"%d" ,n);
				
			else {
				for (i=mbg ; i>=0 ; i--){
					for (j=0 ; j<=mbc ; j++){
						if (i+j<=ld){
							nd=n-i*ng-j*nc;
							if (nd>=0){
									if (nd<min){
										min=nd;
										bc=j;
										bg=i;
									}
							}
							else break;
						}
						else break;
					}
				}
				fprintf(fo ,"%d %d %.3f" ,bc ,bg ,min);
			}
			fclose(fo);
		}
			
		if(strcmp(w, "Fog") == 0){
			printf("%d %d %.3lf", dc, dg, n);
		}
		
		if(strcmp(w, "Sun") == 0){
			int g ,h ,x;
			g = dc % 6;
			h = ld % 5;
			int a[5][6]={{5,7,10,12,15,20} ,{20,5,7,10,12,15} ,{15,20,5,7,10,12} ,{12,15,20,5,7,10} ,{10,12,15,20,5,7}};
			x=a[h][g];
			n=n+ n*(x/100.0);
			ld=ld-x;
			if ((dc+dg)%3==0)
			{
				fo = fopen("output.out","w");			
				if (mbc>mbg)
					l=mbc;
				else l=mbg;
				
				for (i=l ; i>=0 ; i--){
					for (j=i+2 ; j>=i-2 ; j--){  
						if (i+j<=ld){
							nd=n-i*nc - j*ng;
							if (nd>=0){
								if (nd<min){
									if(i>j){
										min=nd;
										bc=i;
										bg=j;
									}
								}
							}
						}
						else break;
					}
				}	
				fprintf(fo ,"%d %d %.3f" ,bc ,bg ,min);
				fclose(fo);
			}
			
			else if ((dc+dg)%3==1)
				{
					fo = fopen("output.out","w");
					for (i=mbc ; i>=0 ; i--){                      //chay tu so banh chung lonw nhat ve 0
						for (j=0 ; j<=mbg ; j++){                 //chay tu so banh giay bang 0 len so banh giay toi da
							if (i+j<=ld){
								nd=n - i*nc - j*ng;				//tinh so nep du so nep ban dau tru cho tong so  lam banh chung tru cho tong so nep lam banh giay
								if (nd>=0){
									if (nd<min){
											if(i>j){
												min=nd;
												bc=i;
												bg=j;
											}
									}
								}
								else break;
							}
							else break;
						}
					}
					fprintf(fo ,"%d %d %.3f" ,bc ,bg ,min);
					fclose(fo);	
				}	
					
				else {				
					fo = fopen("output.out","w");
	
					if (frnum(n,ld)==0)
						fprintf(fo ,"%d" ,n);
						
					else {
						for (i=mbg ; i>=0 ; i--){
							for (j=0 ; j<=mbc ; j++){
								if (i+j<=ld){
									nd=n-i*ng-j*nc;
									if (nd>=0){
										if (nd<min){
											if(i>j){
												min=nd;
												bc=j;
												bg=i;
											}
										}
									}
									else break;
								}
								else break;
							}
						}
						fprintf(fo ,"%d %d %.3f" ,bc ,bg ,min);
					}
					fclose(fo);
				}
			}
		}
}
