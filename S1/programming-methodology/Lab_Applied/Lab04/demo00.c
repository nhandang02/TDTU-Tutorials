#include <stdio.h>

int main(){
	int i, j, n;
    int arr[100]; 
    int size;         
                    
    printf("Enter size of the array: ");
    scanf("%d", &size);

    printf("Enter elements in array: ");
    for(i=0; i<size; i++){
        scanf("%d\t", &arr[i]);
    }
    
    printf("Enter row of the array: ");
    scanf("%d", &n);
    
    for(i=0; i<size; i++){
        printf("%d\t", arr[i]);
    }
    return 0;
}
