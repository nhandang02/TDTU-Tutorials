#include <stdio.h>
#include <string.h>
#include <math.h>
#define PI 3.1415926535
int main(){
	int n, dc, dg, ld, bc, bg;
	double nd;
	char w[10],
		Wind[10] = "Wind",
		Sun[10] = "Sun",
		Cloud[10] = "Cloud",
		Rain[10] = "Rain",
		Fog[10] = "Fog";

	FILE *f = NULL;
	f = fopen("input.inp", "r");
	fscanf(f, "%d %d %d %d %s", &n, &dc, &dg, &ld, w);
	
	if(n<0 || n>1001 || dc<0 || dg<0 || ld<0 ||ld>300)	
		printf("-1 -1 %d", n);
	else{
		if(strcmp(w, "Wind") == 0){
			bc = n / pow(dc,2);
			bg = (n-(bc*pow(dc,2))) / ((dg*dg*PI)/4);
			nd = n - bc*pow(dc,2) - bg*(  (dg*dg*PI)/4);
			if(bc+bg<ld){
				printf("%d %d %.3lf", bc, bg, nd);
			}
			else
				return 0;
		}
		else if(strcmp(w, "Fog") == 0){
			bc = dc;
			bg = dg;
			nd = n;
			printf("%d %d %.3lf", bc, bg, nd);
		}
		else if(strcmp(w, "Sun") == 0){
			int G, H, X;
			G = dc % 6;
			H = ld % 5;
			if(G-H==0)
				X = 5;
			else if(G-H==1)	
				X = 7;
			else if(G-H==2 || H-G==4)
				X = 10;
			else if(G-H==3 || H-G==3)
				X = 12;
			else if(G-H==4 || H-G==2)
				X = 15;
			else if(G-H==5 || H-G==1)
				X = 20;
			else 
				return 0;
			n = n * (100+X) / 100;
			ld = ld - X;
			
//			if((dc+dg)%3==0)
//				return 0;		
			if((dc+dg)%3==1){
				bc = n / pow(dc,2);
				bg = (n-(bc*pow(dc,2))) / ((dg*dg*PI)/4);
				nd = n - bc*pow(dc,2) - bg*(  (dg*dg*PI)/4);
			}
//			else if((dc+dg)%3==2)
//				return 0;
			else 
				return 0;
			if(bc+bg<ld){
				printf("%d %d %.3lf", bc, bg, nd);
			}
			else
				return 0;
		}
	}
	fclose(f);
	return 0;
}
