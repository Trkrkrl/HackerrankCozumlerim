using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}
//---------------------------------------------------------------------------------------------------
class MyBook:Book{//classsimizi olusturalim ve  book a reference verelim
    
    int price=0;//fiyat i olusturalim
    //ctor u olsuturalim ve  base verelim onceki ornek gibi,
     public MyBook(string t, string a, int p) : base(t, a)
    {
        price = p;
    }
    public override void display()// the void displa() method should print and label the respective title,
    //yani diyorki displayi override ile calistir, istedigi  outpu seklinde cikti al
    {
        Console.WriteLine($"Title: {title}\nAuthor: {author}\nPrice: {price}");
    }
}

//Write MyBook class
//---------------------------------------------------------------------------------------------------

class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}
