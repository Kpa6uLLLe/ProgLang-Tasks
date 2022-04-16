#include <iostream>
#include <math.h>
#include <iomanip>
using namespace std;

struct fear{
	float re;
	float im;
};

float calc(float X, float Y)
{
	float c,d;
	c=sinh(X)*cos(Y);
	d=cosh(X)*sin(Y);
	cout<<setprecision(16)<<c<<" + "<<d<<"i\n";
}
int main()
{
	fear a;
	cout<<"a.re\n";
	cin>>a.re;
	cout<<"a.im\n";
	cin>>a.im;
	calc(a.re,a.im);
}
