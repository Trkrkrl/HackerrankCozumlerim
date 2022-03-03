using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {

	public static  Node insert(Node head,int data)//node turunde donen bir method
	{//------------------------------------------------------------
      //Linkedlist yapisi : head(bas) ve node (diger parcalari- ekleri)
      //gorseli incele
      if (head == null) //bas (head) var mi kontrol et-null ise yani yok ise yeni head olustur
      {
         head = new Node(data); //head = yeni node (verilen data ile)
      }
      else //head var ise
      {
        Node curr = head;//curr current:yani su anki- su anki nodu head e esitle
          
            while (curr.next != null) //bir sonraki -yani pesine gelen olmayana kkadar,ssonuncu ya kadar
            {
                curr = curr.next;//her suankiye sonrakini ekle, yeni suanki bu olsun
            }
            curr.next = new Node(data);//sona da bos new node koy
      }
      
      
        return head;
    }
//------------------------------------------------------------------
	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
		display(head);
	}
}
	
