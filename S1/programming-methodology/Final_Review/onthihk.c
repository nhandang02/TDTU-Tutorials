#include <stdio.h>
#include <math.h>
//void main()
//{
//	int i;
//	for(i=‘f’;i<‘i’;i++)
//	{
//		printf(“%d”,i);
//	}
//}

//void main()
//{
//	int a = 20, b = 21;
//	int *c = &a, *d = &b;
//	(*d)++;
//	*c = *c + *d;
//	printf("a = %d, b = %d, c = %d, d = %d",a,b,*c,*d);
//}


//void main()
//{
//	int i, a, b;
//	i = 2023;
//	a = 2 + ++i;
//	printf("%d\n", i);
//	b = 2 + --i;
//	printf("%d\n", i);
//	printf("a = %d,b = %d",a,b);
//}

//int f(int a, int b)
//{
//	if(a > b) return 0;
//	if(a == b) return 1;
//	return b + f(a,b - 1);
//}
//
//int main()
//{
//	printf("%d\n",f(10,20));
//	printf("%d\n",f(30,40));
//	printf("%d", f(50,60));
//	return 0;
//}























//void main()
//{
//	int n1 = 365, n2 = 850;
//	while(n1 != n2)
//	{
//		if(n1 > n2)
//		n1 -= n2;
//		if(n2 > n1)
//		n2 -= n1;
//	}
//	printf("n1 = %d,n2 = %d",n1,n2);
//}


//void main() {
//	int a,b,c,d;
//	a = b = 404;
//	c = a + a++ + --a + ++a + a--;
//	printf("%d\n", c);
//	d = b + ++b + b-- + b++ + --b;
//	printf("%d\n", d);
//	printf("ket qua c= %d, d= %d \n",c,d);
//	if(c == d){
//		printf("ket qua c bang d");
//	}
//	else{
//		printf("ket qua c khac d");
//	}
//}


//void main()
//{
//	int x, y, z, a = 4, b = -2 , c = 0;
//	x = ((a < b || b > c) && a != b);
//	y = ((a > b || b < c) && a == b);
//	z = (b < (a > b)) || ((a > b) && !(b > c));
//	printf("x = %d, y = %d, z = %d",x,y,z);
//}


//#include <stdio.h>
//#include <string.h>
//void main()
//{
//	char s1[50] = " ", s2[50] = " ", s3= "abcde";
//	strcpy(s1,s3);
//	strcpy(s3,s2);
//	printf("s1: %s s2: %s s3: %s",s1,s2,s3);
//}



//void main()
//{
//	int i,s = 0;
//	for (i=1; i<=9; i++)
//	{
//		if(i%2 == 0)
//		break;
//		s = s + i;
//	}
//	printf("%d",s);
//}


//void main()
//{
//	int i,s = 0;
//	for (i=2; i<=6; i+=2)
//	{
//		if(i%2 == 0)
//		continue;
//		s = s + i;
//	}
//	printf("%d",s);
//}
int main(){
	int n = pow(3,2);
	printf("%d", n);
}
