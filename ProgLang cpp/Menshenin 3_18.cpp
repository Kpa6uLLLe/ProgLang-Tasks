#include <iostream>
#include <math.h>
#include <iomanip>
using namespace std;

int main()
{
setlocale( LC_ALL,"Russian" );
const int N=3;
int i,k,n;
double x,f,df;
double a[N+1],b[N];
cout<<"�������� �����������(�����������=1000)"<<endl;
cin>>n;
cout<<"������� ������ �������������"<<endl;
for (i=0;i<N+1;i++)
{

cin>>a[i];
if (a>0)
b[i-1]=i*a[i];
}
cout<<"�����������"<<endl;
cin>>x;
for (k=1;k<n;k++)
{
	f=a[0];
	df=0;
	for(i=1;i<N+1;i++)
	{
		f+=a[i]*pow(x,i);
		df+=b[i-1]*pow(x,i-1);
		
	}
	
	x-=f/df;
}
cout<<setprecision(16)<<"x= "<<x<<endl<<"f("<<x<<")="<<f<<endl;
}
