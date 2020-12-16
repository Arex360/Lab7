using System;
using System.Collections;
namespace cLinkedList{
    public class Node{
        public int data;
        public Node next;
        public Node(int data){
            this.data = data;
            next = null;
        }

    }
     class SingleLinkedList{
        public Node head;
        public void insert(int data){
            Node node = new Node(data);
            if(head == null){
                head = node;
            }else{
                Node tmp = head;
                while(tmp.next != null){
                    tmp = tmp.next;
                }
                tmp.next = node;
            }
        }
        public void print(){
            Node tmp = head;
            while(tmp != null){
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }
        }
    }
    class DoubleNode{
        public int data;
        public DoubleNode prev;
        public DoubleNode next;
        public DoubleNode(int data){
            this.data = data;
            prev = null;
            next = null;
        }
    }
    class DoubleLinkedList{
        public DoubleNode head;
        private DoubleNode lastNode(DoubleLinkedList list){
            DoubleNode tmp = list.head;
            while(tmp.next != null){
                tmp = tmp.next;
            }
            return tmp;
        }
        public void insert(int data){
            DoubleLinkedList list = this;
            DoubleNode newNode = new DoubleNode(data);
            if(list.head == null){
                newNode.prev = null;
                list.head = newNode;
                return;
            }else{
                DoubleNode prevNode = lastNode(list);
                prevNode.next = newNode;
                newNode.prev = prevNode;

            }

        }
        public void print(){
            DoubleNode tmp = head;
            while(tmp != null){
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }
        }
        public void detectDuplicate(){
            DoubleNode tmp = head;
            ArrayList arr = new ArrayList();
            while(tmp != null){
                arr.Add(tmp.data);
                tmp = tmp.next;
            }
            arr.Sort();
            for(int i = 0 ; i < arr.Count ; i++){
                for(int j = 1 ; j < arr.Count - 1; j++){
                    if(arr[i] == arr[j]){
                        arr.RemoveAt(i);
                    }
                }
            }
            foreach(int i in arr){
                Console.WriteLine(i);
            }
        }
    }
     class List{  
         public static Node sort(Node n1, Node n2)  {  
        Node tmp = new Node(0);  
        Node tail = tmp;  
        while(true){  
            if(n1 == null){  
                tail.next = n2;  
                break;  
            }  
            if(n2 == null){  
                tail.next = n1;  
                break;  
            }  
            if(n1.data <= n2.data){  
                tail.next = n1;  
                n1 = n1.next;  
            }  
            else{  
                tail.next = n2;  
                n2 = n2.next;  
            }  
            tail = tail.next;  
        }  
        return tmp.next;  
    }
    public static DoubleNode sort(DoubleNode n1, DoubleNode n2)  {  
        DoubleNode tmp = new DoubleNode(0);  
        DoubleNode tail = tmp;  
        while(true){  
            if(n1 == null){  
                tail.next = n2;  
                break;  
            }  
            if(n2 == null){  
                tail.next = n1;  
                break;  
            }  
            if(n1.data <= n2.data){  
                tail.next = n1;  
                n1 = n1.next;  
            }  
            else{  
                tail.next = n2;  
                n2 = n2.next;  
            }  
            tail = tail.next;  
        }  
        return tmp.next;  
    }  
  }
}