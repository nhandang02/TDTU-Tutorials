#include <stdio.h>
#include <string.h>
int main(){
    char s[100];
    int i, m;
    FILE *fin,*fout;
    fin = fopen("input02.txt", "r");
    fout = fopen("output02.txt", "w");
    for(i=1; i<6; i++){
    	fgets(s, 100, fin);	
    	m=strlen(s);
        if(i<6){
            fprintf(fout,"Length of %d string: %d\n", i, m);
        }
	}
	fclose(fin);
	fclose(fout);
    return 0;
}

