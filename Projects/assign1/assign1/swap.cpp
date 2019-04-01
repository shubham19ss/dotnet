#include<iostream>
using namespace std;
void swap_value(int a,int b)
{
	a = a + b;
	b = a - b;
	a = a - b;
}
void swap_reference(int &a, int &b) {
	a = a + b;
	b = a - b;
	a = a - b;
}
int main() {
	int a, b,c;
	cin >> a >> b;
	cout << "enter choice\n1.Swap by value\n2.Swap by reference\n";
	cin >> c;
	if (c == 1)
		swap_value(a, b);
	else
		swap_reference(a, b);
	cout << a << " "<<b;
	return 0;
}