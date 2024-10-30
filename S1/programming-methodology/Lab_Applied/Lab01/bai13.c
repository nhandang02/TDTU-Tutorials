#include <stdio.h>

int main()
{
    int Physics, Chemistry, Biology, Mathematics, Computer; 
    float Percentage; 

    printf("Enter five subjects marks: \n");
    scanf("%d %d %d %d %d", &Physics, &Chemistry, &Biology, &Mathematics, &Computer);

    Percentage = (Physics + Chemistry + Biology + Mathematics + Computer) / 5.0;

    printf("Percentage = %.2f\n", Percentage);

    if(Percentage >= 90)
    {
        printf("Grade A");
    }
    else if(Percentage >= 80)
    {
        printf("Grade B");
    }
    else if(Percentage >= 70)
    {
        printf("Grade C");
    }
    else if(Percentage >= 60)
    {
        printf("Grade D");
    }
    else if(Percentage >= 40)
    {
        printf("Grade E");
    }
    else
    {
        printf("Grade F");
    }

    return 0;
}
