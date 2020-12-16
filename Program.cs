using System;
using cLinkedList;
namespace lab7
{
    class Program
    {
        static void SortSingleList(){
             SingleLinkedList list1 = new SingleLinkedList();
             SingleLinkedList list2 = new SingleLinkedList();

           list1.insert(8);
           list1.insert(10);
           list1.insert(12);
           list1.insert(17);
           
           list2.insert(1);
           list2.insert(2);

           list1.head = List.sort(list1.head,list2.head);
           
          // list1.head =  List.sort(list1.head,list2.head);
           list1.print();
        }
        static void SortDoubleList(){
             DoubleLinkedList list1 = new DoubleLinkedList();
             DoubleLinkedList list2 = new DoubleLinkedList();

           list1.insert(3);
           list1.insert(100);
           list1.insert(9);
           list1.insert(19);
           
           list2.insert(300);
           list2.insert(111);

           list1.head = List.sort(list1.head,list2.head);
           list1.print();
        }
        static void RemoveDuplicate(){
            DoubleLinkedList list = new DoubleLinkedList();
            list.insert(1);
            list.insert(2);
            list.insert(1);
            list.insert(2);
            list.insert(5);
            list.insert(6);
            list.insert(5);
            list.insert(10);
            list.detectDuplicate();
        }
        static string choice(){
            string temp;
            Console.WriteLine("Press 1 to sort 2 single linked list");
            Console.WriteLine("Press 2 to sort 2 double linked list");
            Console.WriteLine("Press 3 to delete duplicates in double linked list");
            Console.Write("Choose: ");
            temp = Console.ReadLine();
            return temp;
        }        
        static void Main(string[] args)
        {
             string choose = choice();
             switch(choose){
                 case "1":
                     SortSingleList();
                     break;
                 case "2":
                     SortDoubleList();
                     break;
                 case "3":
                     RemoveDuplicate();
                     break;
             }
        }
    }
}
