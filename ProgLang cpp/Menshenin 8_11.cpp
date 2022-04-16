#include <iostream>
#include <math.h>
#include <stdlib.h>
#include <time.h>
using namespace std;
int pseudo()
{
int check=-1;
printf("ѕсевдослучайное заполнение? (0 нет /1 да)\n");
cin>>check;
cout<<"\n\n";
if (check==0 || check==1)
return check;
else
pseudo();
}
class victor{
	
	public:
		int fill;
	
		float *arr=new float;
		void mas(int n)
		{
			fill=pseudo();
			arr = new float[n];
			if (fill==0)
			{
				for (int i=0;i<n;i++)
				{
					cout<<"#"<<i<<"-й элемент массива-вектора \n";
					cin>>arr[i];
				}
			}
			else{
			for(int i=0;i<n;i++)
			{
				arr[i]=rand()%50-rand()%50+(float(rand()%100)/100);
				cout<<arr[i]<<"     ";
			}	
			cout<<endl<<endl;
		}
		}
}v1,v2;

float top(victor &v1, victor &v2,int n)
{
	float sum=0;
	for(int i=0;i<n;i++)
	{
		sum+=v1.arr[i]*v2.arr[i];
	}
	return sum;
}

float leng(victor &v,int n)
{
	float sum=0;
	for(int i=0;i<n;i++)
	{
		sum+=pow(v.arr[i],2);
	}
	return sqrt(sum);
}
int main(){
		setlocale( LC_ALL,"Russian" );
		float a,t,b,fi;
		cout<<"размерность векторов\n";
		cin>>a;
		srand(time(NULL));
		srand(rand()%10);
		v1.mas(a);
		srand(rand()%10);
		v2.mas(a);
		t=top(v1,v2,a);
		b=leng(v1,a)*leng(v2,a);
		fi=acos(t/b)*57.2957795131;
		cout<<endl<<endl<<"”гол между векторами равен: "<<fi;
}
