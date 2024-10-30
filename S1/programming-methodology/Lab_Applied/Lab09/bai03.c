#include <stdio.h>
#include <stdlib.h>

void read_Input(char *, int *, int *);
void write_Output(int, int);
void sequence_Search(int *, int, int);
void binary_Search(int *, int, int);

int main()
{
    char filename[100], buff[255];
    int arr[100];
    int len, choise, key;

    printf("Enter a file name: ");
    scanf("%s", &filename);
    read_Input(filename, arr, &len);

    printf("Choose one of the following: ");
    printf("(1) The sequential search algorithm.\n");
    printf("(2) The binary search algorithm.\n");
    printf("Enter (1)/(2) to select: ");
    scanf("%d", &choise);
    printf("Enter a value to search for: ");
    scanf("%d", &key);

    if (choise == 1)
        sequence_Search(arr, len, key);
    else if (choise == 2)
        binary_Search(arr, len, key);

    return 0;
}

void read_Input(char *filename, int *arr, int *len)
{
    FILE *fr;
    fr = fopen(filename, "r");
    if (fr == NULL)
    {
        printf("File name error");
        exit(1);
    }

    fscanf(fr, "%d", len);
    int i;
    for (i = 0; i < *len; i++)
        fscanf(fr, "%d", &arr[i]);

    fclose(fr);
}

void write_Output(int x, int pos)
{
    FILE *fw;
    fw = fopen("output3.txt", "w");

    if (x == 0)
        fprintf(fw, "Not found");
    else
        fprintf(fw, "The position of the target value is %d", pos + 1);

    fclose(fw);
}

void sequence_Search(int *arr, int len, int key)
{
    int i;

    for (i = 0; i < len; i++)
    {
        if (arr[i] == key)
        {
            write_Output(1, i);
            exit(1);
        }
    }
    write_Output(0, 0);
}

void binary_Search(int *arr, int len, int key)
{
    int start = 0;
    int end = len - 1;

    while (start <= end)
    {
        int mid = (start + end) / 2;

        if (key == arr[mid])
        {
            write_Output(1, mid);
            exit(1);
        }
        else if (key > arr[mid])
            start = mid + 1;
        else
            end = mid - 1;
    }
    write_Output(0, 0);
}
