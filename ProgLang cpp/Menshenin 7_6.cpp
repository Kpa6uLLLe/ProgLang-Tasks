#include <iostream>
#include <math.h>
using namespace std;

class sincalc{
	public:
	float x,sum=1,prod=1;
	int N;
	
	float method(float x, float N){
		prod=1;
		for(int i=1;i<=N;i++)
		{
			prod*=(2*i+1)*(2*i);
			sum+=(pow(-1,i)*pow(x,2*i))/prod;
			
		}
		cout<<"sin(x)/x= "<<sum;
	}
	
	
}sinx;

int main()
{
	setlocale( LC_ALL,"Russian" );
	float a,b;
	cout<<"x,количество итераций\n";
	cin>>a>>b;
	sinx.method(a,b);
	
	
}
