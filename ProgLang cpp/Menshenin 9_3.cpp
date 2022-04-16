#include <iostream>
#include <string>
using namespace std;
int count=-1;
int count2=0;
class tree{
	public:
	tree *p1,*p2;
	int n;
	tree(int x){
		tree *p,*q;
		count+=2;
		
		cout<<"\n"<<count;
		if (x>0)
		{
		p->p1=new tree(x-1);
		p->n=count;
		count2+=2;
		//q=new
		}
		
		
	}

};
/*
	tree *obj2(int x){
		tree *p,*q;
		p = new tree(x);
		count++;
		p->n=count;
		q = new tree(x);
		count++;
		q->n=count;
		p->p2=q;
		q->p2=p;
		
	}
	tree *obj1(int x){
		tree *q,*p;
		p = new tree(x);
		count++;
		p->n=count;
		q = new tree(x);
		count++;
		q->n=count;
		p->p2=p;
		q->p2=q;
		if(x>1){
			p->p1=obj2(x-1);
			q->p1=p->p1->p2;
		}
	}
*/



int main(){
	setlocale( LC_ALL,"Russian" );
	int n;
	cout<<"количество слоёв: \n";
	cin>>n;
	tree *q;
	q=new tree(n);
	cout<<"\ndsadas"<<q->n;
	cout<<"\n"<<count;
}
