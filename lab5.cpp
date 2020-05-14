#include <iostream>
#include <math.h>
using namespace std;

class Line
{
    private:
    float coordBeginX;
    float coordBeginY;
    float coordEndX;
    float coordEndY;

    public:
    Line();
    Line(float x1, float y1, float x2, float y2);
    float LineLength();
};
class LineSegment: public Line
{
    private:
    float beginX;
    float beginY;
    float endX;
    float endY;

    public:
    LineSegment();
    LineSegment(float x1, float y1, float x2, float y2);
    float Angle();
    float getXbegin();
    float getYbegin();
    float getXend();
    float getYend();
};
//////////////////методи класу Лінії
Line::Line()
{
    coordBeginX = 0;
    coordBeginY = 0;
    coordEndX = 0;
    coordEndY = 0;
}
Line::Line(float x1, float y1, float x2, float y2)
{
    coordBeginX = x1;
    coordBeginY = y1;
    coordEndX = x2;
    coordEndY = y2;
}
float Line::LineLength()
{
    if(coordEndX&&coordEndY != 0 && coordBeginX&&coordBeginY != 0)
       return sqrt(pow((coordEndX - coordBeginX),2)+pow((coordEndY - coordBeginY),2));
    else
       return 0; 
}
//////////////////////////////методи похідного класу Відрізки
LineSegment::LineSegment()
{
    beginX = 0;
    beginY = 0;
    endX = 0;
    endY = 0;
}
LineSegment::LineSegment(float x1, float y1, float x2, float y2)
{
    beginX = x1;
    beginY = y1;
    endX = x2;
    endY = y2;
}
float LineSegment::Angle()
{
    return (abs(endY - beginY))/(abs(endX - beginX));
}
float LineSegment::getXbegin(){return beginX;}
float LineSegment::getYbegin(){return beginY;}
float LineSegment::getXend(){return endX;}
float LineSegment::getYend(){return endY;}

int main()
{
    cout<<"\nЛабораторна №5 ООП Павлик Вікторії ІС-93"<<endl;
    cout<<"\nУспадкування та поліморфізм класів"<<endl;
    LineSegment *plineSegm = new LineSegment(9, 13, 5, 3);
    cout<<"\nКоординати початку відрізка: ("<<plineSegm -> getXbegin()<<", "<<plineSegm -> getYbegin()<<")"<<endl;
    cout<<"\nКоординати кінця відрізка: ("<<plineSegm -> getXend()<<", "<<plineSegm -> getYend()<<")"<<endl;
    cout<<"\nДовжина даного відрізка: "<<plineSegm -> LineLength()<<endl;
    cout<<"\nТангенс кута з віссю OX: "<<plineSegm -> Angle()<<endl;
    cout<<"\nКут з віссю OX: "<<tan(plineSegm -> Angle())<<endl;
}