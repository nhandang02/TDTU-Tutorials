//#include <stdio.h>
//#include <string.h>
// 
////int WordCount(char str[], int length)
////{
////    int word = (str[0] != ' ');
////    int i;
////    for (i = 0; i < length - 1; i++)
////    {
////        if (str[i] == ' ' && str[i + 1] != ' ')
////        {
////            word++;
////        }
////    }
////    return word;
////}
////
////int main()
////{
////    char str[100];
////    printf("Nhap chuoi: ");
////    fgets(str, 100, stdin);
////    int length = strlen(str) - 1; 
////    str[length] = '\0';
////    printf("So tu cua \"%s\" la %d", str, WordCount(str, length));
////}
//
//#include<stdio.h>
//
//#include<string.h>
//
//#define max 100
//
//char CatHoTen(char s[],char s1[])
//
//{
//
//                                             int len=strlen(s);
//
//                                             int i = len-1,j;
//                                             printf("%d", i);
//
//                                             int m=0;
//
//                                             while(i>=0)
//
//                                             {
//
//                                                if((s[i]==' ') && (s[i+1]!=' '))
//
//                                                {
//
//                                                            for(j=i+1;j<len;j++)
//
//                                                            {
//
//                                                                        s1[m]=s[j];
//
//                                                                        m++; 
//
//                                                            }
//
//                                                            s[i]='\0';
//
//                                                            break;
//
//                                                }
//
//                                                i--;
//
//                                             } 
//
//
//                                             printf("%s",s1);
//
//}
//
//int main()
//
//{
//
//                                             char s[max];
//
//                                             char s1[max];
//                                             char s2[max];
//
//                                             printf("Nhap xau: ");
//
//                                             gets(s);
//
//                                            
//
//                                             printf("Ten: ");
//											 CatHoTen(s,s1);
//											 printf("\n");
//											 printf("Ten lot: ");
//                                             CatHoTen(s,s2);
//                                             printf("\n");
//                                             printf("Ho: %s", s);
//
//}
//


#include <stdio.h>
#include <string.h>

//void main(){
//	char a[100] = "", b[100] = "", c[100] ="abcdefg";
//	strncpy(a,c,2);
//	strncpy(b,"12345",7);
//	printf("a: %s\nb: %s\nc: %s\n", a, b, c);
//	return 0;
//}

void main(){
	char a[2]="12";
	char b[3]="2";
	printf("%d", atoi(a) + atoi(b));
	return 0;
}
