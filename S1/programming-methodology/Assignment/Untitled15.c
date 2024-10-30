#include <stdio.h>
#include <string.h>
#include <math.h>
#define PI 3.1415926535

int frnum(int n, int ld){
	int i, sn=0, sld=0;
	for(i=1; i<n; i++){
		if(n%i==0)
			sn+=i;
	}
	for(i=1; i<ld; i++){
		if(ld%i==0)
			sld+=i;
	}
	if(sn==ld && sld==n){
		return 0;
	}
	else
		return 1;	
}

void Wind(int n, int dc, int dg, int ld){
	int i, j, bc=0, bg=0, mbc, mbg;
	double nd;
	int nc=dc*dc;
	float ng=(dg*dg*PI)/4;
	
	if(dc<1) mbc=0;
	else mbc=n/nc;
	if(dg<1) mbg =0;
	else mbg=n/ng;
	
	
	float min=n;
	FILE *fo;
	fo = fopen("output.out","w");	
	for (i=mbc ; i>=0 ; i--){                  
		for (j=0 ; j<=mbg ; j++){              
			if (i+j<=ld){
				nd = n - i*nc - j*ng;	
				if (nd>=0){
					if(nd<=min){
						min=nd;
						bc=i;
						bg=j;
					}
				}
				else break;
			}
			else break;
		}
		if(min!=n) break;
	}
	fprintf(fo ,"%d %d %.3f" ,bc ,bg ,min);
	fclose(fo);	 	
}

void Rain(int n, int dc, int dg, int ld){
	int i, j, l, bc=0, bg=0, a, bcbg;
	double nd, nd1, nd2;
	int nc=dc*dc;
	float ng=(dg*dg*PI)/4;
	float min=n;
	FILE *fo;
	fo = fopen("output.out","w");
	
	if(dc<1) nc=999999;
	else nc=dc*dc;
	if(dg<1) ng=999999;
	else ng=(dg*dg*PI)/4;
				
	bcbg = n / (nc+ng);
	if(bcbg > ld/2) bcbg = ld/2;
	bc = bg = bcbg;
	ld = ld - bc - bg;
	nd1 = n - bc*nc - bc*ng; 
				
	if((nd1>=nc || nd1>ng) && nc>ng )
	{
		a = nd1/nc;
		if(a>ld) a=ld;
					
		bc = bc + a;
		nd2 = nd1 - a*nc;
		ld-=a;
		if(nd2>=ng)
		{
			a = nd2/ng;
			if(a>ld) a=ld;
			bg = bg + a;
			nd = nd2 - a*ng;
		}
		else nd = nd2;
	}
	else if((nd1>=nc || nd1>ng) && ng>nc)
	{
		a = nd1/ng;
		if(a>ld) a=ld;
					
		bg = bg + a;
		nd2 = nd1 - a*ng;
		ld-=a;
		if(nd2>=nc)
		{
			a = nd2/nc;
			if(a>ld) a=ld;
			bc = bc + a;
			nd = nd2 - a*nc;
		}
		else nd = nd2;
	}
	else
	{
		nd = nd1;
	}
	
	fprintf(fo ,"%d %d %.3f" ,bc ,bg ,nd);
	fclose(fo);
}

void Cloud(float n, int dc, int dg, int ld){
	int i, j, bc=0, bg=0, mbc, mbg;
	double nd;
	int nc=dc*dc;
	float ng=(dg*dg*PI)/4;
	
	if(dc<1) mbc=0;
	else mbc=n/nc;
	if(dg<1) mbg =0;
	else mbg=n/ng;
	
	float min=n;
	FILE *fo;
	fo = fopen("output.out","w");
			
	if (frnum(n,ld)==0)
		fprintf(fo ,"0 0 %.3f" ,n);
				
	else {
		for (i=mbg ; i>=0 ; i--){
			for (j=0 ; j<=mbc ; j++){
				if (i+j<=ld){
					nd = n - i*ng - j*nc;
					if (nd>=0){
						min=nd;
						bc=j;
						bg=i;
					}
					else break;
				}
				else break;
			}
			if(min!=n) break;
		}
		fprintf(fo ,"%d %d %.3f" ,bc ,bg ,min);
	}
	fclose(fo);
}

void Fog(float n, int dc, int dg, int ld){
	(float)(n);
	FILE *fo;
	if(dc<1) dc=0;
	else dc=dc;
	if(dg<1) dg=0;
	else dg=dg;
	fo = fopen("output.out","w");
	fprintf(fo,"%d %d %.3f", dc, dg, n);	
	fclose(fo);
}

void Sun(int n, int dc, int dg, int ld){
	FILE *fo;
	int G, H, X;
	if(dc>0)
	{
		G = dc % 6;
		H = ld % 5;
		int a[5][6]={{5,7,10,12,15,20} ,{20,5,7,10,12,15} ,{15,20,5,7,10,12} ,{12,15,20,5,7,10} ,{10,12,15,20,5,7}};
		X = a[H][G];
		n = n + n*(X/100.0);
		ld = ld-X;
	}
	
	
	float t=n;
	if(dg<0) dg=0;
	if ((dc+dg)%3==0)
	{
		if(ld<1)
		{
			fo = fopen("output.out","w");
			fprintf(fo,"0 0 %.3f", t);	
			fclose(fo);
		}
		else Rain(n, dc, dg, ld);
	}	
		
	else if ((dc+dg)%3==1)
	{
		if(ld<1)
		{
			fo = fopen("output.out","w");
			fprintf(fo,"0 0 %.3f", t);	
			fclose(fo);
		}
		else Wind(n, dc, dg, ld);	
	}	
	else
	{
		if(ld<1)
		{
			fo = fopen("output.out","w");
			fprintf(fo,"0 0 %.3f", t);	
			fclose(fo);
		}
		else Cloud(n, dc, dg, ld);	
	}
	
}

void main(){		
	int n, dc, dg, ld;
	double nd;
	char w[10];
	FILE *fi,*fo;
	fi = fopen("input.inp", "r");
	
	fscanf(fi, "%d %d %d %d %s", &n, &dc, &dg, &ld, w);
	fclose(fi);
	
	if(n<0 || n>1000 || ld<1 ||ld>300)
	{	
		float n1=n;
		fo = fopen("output.out","w");
		fprintf(fo,"-1 -1 %.3f",n1);	
		fclose(fo);
	}
	else{
		if(strcmp(w, "Wind") == 0){
			 Wind(n, dc, dg, ld);	
		}
		
		if(strcmp(w, "Rain") == 0){
			Rain(n, dc, dg, ld);
		}
		
		if(strcmp(w, "Cloud") == 0){				
			Cloud(n, dc, dg, ld);
		}
			
		if(strcmp(w, "Fog") == 0){
			Fog(n, dc, dg, ld);	
		}
		
		if(strcmp(w, "Sun") == 0){
			Sun(n, dc, dg, ld);
		}
	}
}
