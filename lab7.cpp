#include <iostream>
#include <string.h>
#include <stdio.h>
#include <stdlib.h>

using namespace std;

struct list
{
  char value; // значення вузла
  struct list *ptr; // покажчик на наступний елемент
};

struct list * init(char a) 
{
  struct list *lst;
  // виділення пам'яті для голови списку
  lst = (struct list*)malloc(sizeof(struct list));
  lst->value = a;  // значення першого вузла
  lst->ptr = NULL; // останній вузол списку
  return(lst);
}

struct list * add(list *lst, char symbol)
{
  struct list *temp, *p;
  temp = (struct list*)malloc(sizeof(list));
  p = lst->ptr; // зберігаємо покажчик на наступний вузол
  lst->ptr = temp; // попередній вузол вказує на новий
  temp->value = symbol; // збереження значення нового вузла
  temp->ptr = p; // новий вузол вказує на наступний елемент
  return(temp);
}

struct list * del(list *lst, list *root)
{
  struct list *temp;
  temp = root;
  while (temp->ptr != lst) // проходимо список від кореня
  { // доки не дійдемо до вузла, що стоїть перед тим, що видаляється
    temp = temp->ptr;
  }
  temp->ptr = lst->ptr; // зміщуємо покажчик
  free(lst); // вивільнення пам'яті видаленого вузла
  return(temp);
}

void listprint(list *lst)
{
  struct list *p;
  p = lst;  // покажчик на голову
  do {
    cout<<p->value<<" "; // виводимо значення поточного вузла
    p = p->ptr; // переходимо до наступного вузла
  } while (p != NULL);
}

int main()
{
    struct  list* p1 = (struct list*)malloc(sizeof(struct list));
    char a('a');
    char b('b');
    char c('c');
    char ch('!');

    p1 = init(a);
    add(p1, b);
    add(p1, c);
    add(p1, ch);
    listprint(p1);
    listprint(p1);
}