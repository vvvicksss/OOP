#include <iostream>
#include <bitset>
using namespace std;

int increase(int &c)
{
    int i;
    for (i = 1; (c & i) != 0; i <<= 1)
        c &= ~i;
 
    c |= i;
}

bool compare(int a, int b, int bit)
{
    bit = 1<<bit;       
    a &= bit;         
    b &= bit;       
    return !(a^b);
}


int main()
{
    cout<<"\nЛабораторна №1 ООП Павлик Вікторії ІС-93"<<endl;
    int c1 = 31, c2 = 56, c3 = -25;//число для побітового збільшення
    int a1 = 44, a2 = 46;//числа для порівняння
    int b1 = 44, b2 = -7;//числа для порівняння
    int bit = 2;
    cout<<"\nВихідні числа: "<<c1<<"\t"<<c2<<"\t"<<c3<<endl;
    increase(c1);
    increase(c2);
    increase(c3);
    cout<<"\nЗбільшені на 1 числа: "<<c1<<"\t"<<c2<<"\t"<<c3<<endl;

    cout<<"\nЧисла для порівняння: "<<a1<<"\t"<<b1<<endl;
    cout<<"\nРезультат порівняння: "<<compare(a1,b1, bit)<<endl;

    cout<<"\nЧисла для порівняння: "<<a2<<"\t"<<b2<<endl;
    cout<<"\nРезультат порівняння: "<<compare(a2,b2, bit)<<endl;
}
