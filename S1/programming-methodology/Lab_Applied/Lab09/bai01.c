#include <stdio.h>

int main(){
	int i, num, sum=0;
	FILE *myfile;
	myfile = fopen("input01.txt","r");
	for(i=0; i<20; i++){
		fscanf(myfile,"%d", &num);
		sum+=num;
	}
	fclose(myfile);
	myfile=fopen("output01.txt","w");
	fprintf(myfile,"%d", sum);
	fclose(myfile);
	return 0;
}
