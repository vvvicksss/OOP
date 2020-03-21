#include <iostream>
using namespace std;

class String
{
    public:
    String();//конструктор для створення порожнього рядка
    ~String();//деструктор рядка (масиву чарів)
    String(char *str);//конструктор з переданим як параметр рядком
    String(const String &other);//конструктор копіювання 
    String& operator =(const String &other);//перегрузка оператора "="
    String operator+(const String &other);//пергрузка оператора "+"
    void Print();//метод виводу рядка на екран
    int Length();//метод, який повертає довжину рядка
    bool operator ==(const String &other);//перегрузка оператора "=="
    bool operator !=(const String &other);//перегрузка оператора "!="
    char& operator [](int index);//перегрузка оператора "[]"
    
    
    private:
    char *str;//покажчик на масив символів
    int length;//змінна, яка відповідає за збереження довжини рядка
};
//конструктор для створення порожнього рядка
String::String ()
    {
        str = nullptr;
        length = 0;
    }
//деструктор рядка (масиву чарів)
String::~String()
    {
        delete[] this->str;
    }  
//конструктор з переданим як параметр рядком
String::String(char *str)
    {
        length = strlen(str);
        this->str = new char[length + 1];
        for(int i = 0; i < length; i++)
        {
            this->str[i] = str[i];
        }
        this->str[length] = '\0';
    } 
//конструктор копіювання
String::String(const String &other)
    {
        if(this->str != nullptr)
        {
            delete[] str;
        }
        length = strlen(other.str);
        this->str = new char[length + 1];
        for(int i = 0; i < length; i++)
        {
            this->str[i] = other.str[i];
        }
        this->str[length] = '\0';
    }
//перегрузка оператора "=" призначений для привласнення значення одного рядка іншому
String& String::operator =(const String &other)
    {
        if(this->str != nullptr)
        {
            delete[] str;
        }
        length = strlen(other.str);
        this->str = new char[length + 1];
        for(int i = 0; i < length; i++)
        {
            this->str[i] = other.str[i];
        }
        this->str[length] = '\0';
        return *this;
    }
//перегрузка оператора "+" відповідає за конкатенацію рядків
String String::operator+(const String &other)
    {
        String newStr;
        int thisLength = strlen(this->str);
        int otherLength = strlen(other.str);
        newStr.length = thisLength + otherLength;
        newStr.str = new char[thisLength + otherLength + 1];
        int i = 0;
        for(; i < thisLength; i++)
        {
            newStr.str[i] = this->str[i];
        }
        for(int j = 0; j < otherLength; j++, i++)
        {
            newStr.str[i] = other.str[j];
        }
        newStr.str[thisLength + otherLength] = '\0';
        return newStr;
    }
//метод виводу рядка на екран
void String::Print()
    {
        cout<<str;
    }
//метод, що повертає довжину рядка
int String::Length()
{
    return length;
}
//перегрузка оператора "==", який відповідає за перевірку рядків на рівність
bool String::operator ==(const String &other)
{
    if(this->length != other.length)
    {
        return false;
    }
    for (int i = 0; i < this->length; i++)
    {
        if(this->str[i] != other.str[i])
        {
            return false;
        }
    }
    return true;
}
//перегрузка оператора "!=", який відповідає за перевірку рядків на нерівність
bool String::operator !=(const String &other)
{
    return !(this->operator==(other));
}
//прегрузка оператора "[]"
char& String::operator [](int index)
{
    return this->str[index];
}

int main()
{
    cout<<"\nЛабораторна №2 ООП Павлик Вікторії ІС-93"<<endl;
    String str("My own class String");
    String str1("is working fine");
    cout<<str + str1<<endl;
    return 0;
}