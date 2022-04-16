#include <iostream>
#include <math.h>
using namespace std;
#define PI 3.1415926535
double function1(double mass, double mu,double al)
{
	cout<<"F is "<<mu*mass*9.8*cos(al)<<" newtons";
}
double function2(double mass, double al)
{
	cout<<"F is "<<mass*9.8*sin(al)<<" newtons";
}
int main()
{
	long double f,m,al,mu;
	bool pk;
	cout<<"Input mass(kg) ";
	cin>>m;
	cout<<"Input mu(0.0-1.0) ";
	cin>>mu;
	cout<<"Input alpha(0-90) ";
	cin>>al;
	cout<<"Is body moving?(0/1) ";
	cin>>pk;
	al=al/180*PI;
	pk==1? function1(m,mu,al) : function2(m,al);
}

