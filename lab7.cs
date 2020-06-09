using System;

namespace laba7
{
    class list
    {
    public static Node head = null; // ініціалізуємо голову

    public class Node // клас вузол
    {
      public char value;  // значення вузла
      public Node next; // посилання на наступний вузол
    };

    public static Node Add(char symbol)  // додавання вузла
    {   
      Node newNode = new Node();   // ініціалізуємо новий вузол
      if (head == null)  // якщо список пустий
        head = newNode; // то голова - перший вузол
      newNode.value = symbol;  // додаємо символ
      newNode.next = null;  // присвоюємо покажчик на наступний вузол
      return newNode;
    }
	
	public static Node InitList(string line)  
    {   
      Node lis = null;
      if (line.Length == 0)   // якщо список пустий  
        return null;
      for (int i = 0; i < line.Length; i++)
        if (i == 0) // для першого вузла
        {   
          head = Add(line[i]);    // ініціалізуємо голову 
          lis = head;
        }
        else    
        {   
          lis.next = Add(line[i]);    // встановлюємо покажчик на наступний вузол
          lis = lis.next;  
        }
      return head;
    }

    public static string PrintList()
    {
      string s = "";
      Node lis = head;
      while (lis.next != null) // проходимо всі вузли поки покажчик на наступний не буде NULL
      {   
        s += lis.value;  // записуємо значення списку в string
        lis = lis.next;  // переходимо до наступного вузла
      }
      s += lis.value;  // додаємо останній вузол
      return s;
    }

    public static int FindFirst(char x)   // знайти перше входження символу в список
    {   
      int counter = 0;
      Node lis = head;
      while (lis.next != null) // проходимо всі вузли поки покажчик на наступний не буде NULL
      {   
        if (lis.value == x)  // якщо знайшли необхідний символ
          return counter;
        lis = lis.next;  // переходимо до наступного вузла
        counter++;  
      }
      if (lis.value == x)  // перевіряємо останній символ
        return counter;
      return -1;
    }

    public static void RemoveA(char x)  // видалення символу зі списку
    {
      Node p_lis = null; // попередній вузол
      Node lis = head;    // поточний вузол
      if (head == null)  // якщо список пустий
        return;
      while (lis.next != null && lis != null)   //проходимо всі вузли поки покажчик на наступний не буде NULL
                                                // та список не пустий
      {
        if (lis.value == x)  // якщо знайшли шуканий символ
          if (lis == head) // якщо шуканий вузол - голова
          {   
            head = lis.next;    // голова - наступний вузол 
            lis = head;  // змінюємо значення вузла
          }
          else    // якщо шуканий вузол не голова
          {   
            p_lis.next = lis.next;  // переносимо покажчик на наступний вузол
          }
        p_lis = lis;  // шуканий вузол є попереднім
        lis = lis.next;  // переносимо покажчик
      }
      if (lis.value == x)  // перевіряємо останній вузол
        p_lis.next = null; // видаляємо
    }
  }

    public class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Лабораторна 7 Павлик Вікторії\n\n");
            list Lst = new list();
            list.Node lst = new list.Node();
            list.InitList("bbaccb!acb!aba");
            Console.WriteLine("\nСписок: " + list.PrintList());  
			Console.WriteLine("\n\nІндекс першого входження \"!\":  " + list.FindFirst('!'));
            list.RemoveA('a');
            Console.WriteLine("\n\nСписок після видалення всіх \"a\":  " + list.PrintList() + "\n");
        }
    }
}