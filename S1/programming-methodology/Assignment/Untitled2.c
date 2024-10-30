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

void main()
{
	frnum(220, 284);
	
}
