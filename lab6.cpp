#include <iostream>
#include <math.h>
#include <random>
#include <ctime>
using namespace std;

class Problem
{
    private:
    int a, c, d;

    public:
    Problem();
    Problem(int a, int c, int d);
    void setA(int num);
    void setC(int num);
    void setD(int num);
    int getA();
    int getC();
    int getD();
    float Numerator();
    float Denominator();
    float SquareRoot(int num);
    float ProblemSolution();
};
Problem::Problem()
{
    a = 1;
    c = 1;
    d = 0;
}
Problem::Problem(int a, int c, int d)
{
    this->a = a;
    this->c = c;
    this->d = d;
}
float Problem::Numerator()
{
    try
    {
        float solvedA;
        solvedA = SquareRoot(a);
        return 2*c - d + solvedA;
    }
    catch(...)
    {
        cout<<"\nError! Negative number!\nSquare root is not solved"<<endl;
        cout<<"Solving problem without value of square root"<<endl;
    }
    return 2*c - d;
}
float Problem::SquareRoot(int num)
{
    if (num < 0)
        throw "Negative number under square root!";
    return sqrt(23*num);
}
float Problem::Denominator()
{
    if (a == 4)
    {
        throw "This value leads to division by zero!";
    }
    return a/4 - 1;
}
float Problem::ProblemSolution()
{
    try
    {
        return Numerator()/Denominator();
    }
    catch(...)
    {
        cout<<"\nError! Division by zero"<<endl;
        cout<<"Instead division by 1"<<endl;
    }
    return Numerator();
}
void Problem::setA(int num){a = num;}
void Problem::setC(int num){c = num;}
void Problem::setD(int num){d = num;}
int Problem::getA(){return a;}
int Problem::getC(){return c;}
int Problem::getD(){return d;}
int main()
{
    srand(time(NULL));
    const int n = 50;
    int numbers[n];
    for (int i = 0; i < n; i++)
        numbers[i] = rand()%((n+1)-(-n)+(-n));
    for (int i = 0; i < n; i+=3)
    {
        Problem prob(numbers[i], numbers[i+1], numbers[i+2]);
        cout<<"\n"<<prob.ProblemSolution()<<endl;
    }
    Problem prob2(-2, 4, 2);
    cout<<"\n"<<prob2.ProblemSolution()<<endl;
}