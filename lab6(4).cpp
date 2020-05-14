#include <iostream>
using namespace std;

class Vector
{
    private:
    int r;
    int f;

    public:
    Vector();//конструктор, що ініціалізує координати нулями
    Vector(int vr, int vf);//конструктор з параметрами
    Vector(const Vector &other);//конструктор копіювання
    int Rotate(int vf);//метод повороту вектору на будь-який кут
    void Print();//метод отримання даних вектору
    Vector operator /(const int divisor);//перевантаження оператора ділення
    Vector operator +(const Vector other);//перевантаження оператора додавання
};
//конструктор, що ініціалізує координати нулями
Vector::Vector()
{
    r = 0;
    f = 0;
}
//конструктор з параметрами
Vector::Vector(int vr, int vf)
{
    r = vr;
    f = vf;
}
//конструктор копіювання
Vector::Vector(const Vector &other)
{
    r = other.r;
    f = other.f;
}
//метод повороту вектору на будь-який кут
int Vector::Rotate(int vf)
{
    f += vf;
    return f;
}
//метод отримання даних вектору
void Vector::Print()
{
    cout<<"\nВідстань від полюсу: "<<r<<"\nКут між полярною віссю: "<<f<<endl;
}
//перевантаження оператора ділення
Vector Vector::operator /(const int divisor)
{
    if (divisor == 0)
    {
        throw "Division by zero";
    }
    try
    {
        Vector result;
        result.r = r/divisor;
        result.f = f/divisor;
        return result;
    }
    catch(...)
    {
        cout<<"\nError! Division by zero"<<endl;
        cout<<"Instead division by 1"<<endl;
    }
    Vector result;
    result.r = r;
    result.f = f;
    return result;
}
//перевантаження оператора додавання
Vector Vector::operator +(const Vector other)
{
    Vector result;
    result.r = r + other.r;
    result.f = f + other.f;
    return result;
}
int main()
{
    cout<<"\nЛабораторна №4 ООП Павлик Вікторії ІС-93"<<endl;
    Vector v1;
    Vector v2(6,45);
    Vector v3(v2);
    cout<<"\nВектор 1: "<<endl;
    v1.Print();
    cout<<"\nВектор 2: "<<endl;
    v2.Print();
    cout<<"\nВектор 3: "<<endl;
    v3.Print();
    cout<<"\n\nВектор 2 зменшений у два рази: "<<endl;
    v2 = v2/2;
    v2.Print();
    cout<<"\n\nВектор 3 розвернутий на 45 градусів:"<<endl;
    v3.Rotate(45);
    v3.Print();
    cout<<"\n\nВектор 1 як результат додавання вектора 2 та вектора 3:"<<endl;
    v1 = v2 + v3;
    v1.Print();
}