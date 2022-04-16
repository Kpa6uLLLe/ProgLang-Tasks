#include <iostream>
#include <math.h>
using namespace std;
#define PI 3.1415926535
int main()
{
	double a,b,c,x,al;
	setlocale( LC_ALL,"Russian" );
	cout<<"Введите a: ";
	cin>>a;
	cout<<"Введите b: ";
	cin>>b;
	cout<<"Введите c: ";
	cin>>c;
	if (abs(c)<=sqrt(a*a+b*b)){
	al=atan(b/a);
	x=asin(c/sqrt(a*a+b*b))-al;
	cout<<"Корень уравнения: "<<x*180/PI;
}
else
cout<<"Нет решения.";
}
