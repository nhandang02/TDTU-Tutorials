#include <stdio.h>
#define MAX_SIZE 100
int cnt(int arr[], int size, int freq[]){
	int i, j;
	for(i=0; i<size; i++){
        int count = 0;
        for(j=i+1; j<size; j++){
            if(arr[i]==arr[j]){
                count++;
                freq[j] = 0;  
            }
        }

        if(freq[i] != 0){
            freq[i] = count;
        }
    }

    printf("\nFrequency of all elements of array : \n");
    for(i=0; i<size; i++){
        if(freq[i] != 0){
            printf("%d occurs %d times\n", arr[i], freq[i]);
        }
    }
}

int main(){
    int arr[MAX_SIZE], freq[MAX_SIZE];
    int size, i, j, count;

    printf("Enter size of array: ");
    scanf("%d", &size);

    printf("Enter elements in array: ");
    for(i=0; i<size; i++){
        scanf("%d", &arr[i]);

        freq[i] = -1;
    }
    return cnt(arr, size, freq);
}

	
    

