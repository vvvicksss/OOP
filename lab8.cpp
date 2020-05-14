#include <iostream>
#include <iomanip>
#include <ctime>
using namespace std;
 
void Sort(int *, int); 
 
int main(int argc, char* argv[])
{
    srand(time(NULL));
    const int n = 10;
    void (*sorting) (int *array, int n);

    cout<<"\nмасив до сортування"<<endl;
    int *array = new int [n]; 
    for (int i = 0; i < n; i++)
    {
        array[i] = rand() % 100; 
        cout << setw(2) << array[i] << "  "; 
    }
    cout << "\n\n";
    
    sorting = Sort;
    sorting(array, n); 
    
    cout<<"\nмасив після сортування"<<endl;
    for (int i = 0; i < n; i++)
    {
        cout << setw(2) << array[i] << "  "; 
    }
    cout << "\n";
 
    system("pause");
    return 0;
}
 
void Sort(int* array, int n) 
{
 int temp = 0; 
 bool exit = false; 
 
 while (!exit) 
 {
  exit = true;
  for (int i = 0; i < (n - 1); i++) 
    if (array[i] > array[i + 1]) 
    {
        temp = array[i];
        array[i] = array[i + 1];
        array[i + 1] = temp;
        exit = false; 
    }
 }
}