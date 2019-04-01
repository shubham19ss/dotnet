#include<iostream>
using namespace std;
class Polar {
	int r;
	int a;
	
public:
	static int count;
	Polar() {
		count++;
		cout << "Constructor" << Polar::count << endl;
	}
	~Polar() {
		count--;
		cout << "Destructor" << Polar::count << endl;
	}
};
int Polar::count = 0;
int main() {
	Polar p1,p2,p3,p4;
	getchar();
	return 0;
}