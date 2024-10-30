#include <stdio.h>
#define MAX_SIZE 100
int duplicate_element( int arr[], int size){
	int i, j, k; 
 
    for(i=0; i<size; i++){
        for(j=i+1; j<size; j++){
            if(arr[i] == arr[j]){
                for(k=j; k < size - 1; k++){
                    arr[k] = arr[k + 1];
                }
                size--;
                j--;
            }
        }
    }

    printf("\nArray elements after deleting duplicates : ");
    for(i=0; i<size; i++){
        printf("%d\t", arr[i]);
    }

}

int main(){
	int i  ;
    int arr[MAX_SIZE]; 
    int size;         
                    
    printf("Enter size of the array : ");
    scanf("%d", &size);

    printf("Enter elements in array : ");
    for(i=0; i<size; i++){
        scanf("%d\t", &arr[i]);
    }
    return duplicate_element(arr, size);
}
