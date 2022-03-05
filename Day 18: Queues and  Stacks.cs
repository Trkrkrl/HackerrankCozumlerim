using System;
using System.Collections.Generic;
using System.IO;
//queue - kuyruk ilk giren ilk cikar
//stack -yigin ilk giren son cikar-ust ustte yigilan kitaplar ornegi
//duz ve tersten ayni okunan kelimeler-palindrome
//bir stringdeki kelimelerdeki char lari ayirip  hem kuyruga(enqueue) hem yigina(push) atacagiz
//sonra bu islem bitince  dequeue ve pop yaparak cikaracagiz
//her ckan karakteri karsilastir
//once   2 degisken yani kuyurk ve yigini taniimla
//push ve enqueue methodlari yaz void olsun
//pop ve dequeue methodlari

//karsilastima islerini kendi yapiyor biz sadece pop push ve queue fonkllari yazdik-

class Solution {
    
    Stack<char> harfYigini;//burada tanimalamassak  asagidaki public icerisindeki degiskenlerimizi
    Queue<char> harfKuyrugu;//fonksiyonlar gormuyor
    
    public Solution(){
         harfYigini=new Stack<char>();
         harfKuyrugu = new Queue<char>();
    }
    
   
    
    void pushCharacter(char ch){
        
        harfYigini.Push(ch);
        
        
    }
    void enqueueCharacter(char ch){
        
        
        harfKuyrugu.Enqueue(ch);
        
    }
    char popCharacter(){
        
        return harfYigini.Pop();
        
        
    }
    
    char dequeueCharacter(){
        
       
        return harfKuyrugu.Dequeue();
        
    }
    
//------------------------------------------------------------------------------


    static void Main(String[] args) {
        // read the string s.
        string s = Console.ReadLine();
        
        // create the Solution class object p.
        Solution obj = new Solution();
        
        // push/enqueue all the characters of string s to stack.
        foreach (char c in s) {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }
        
        bool isPalindrome = true;
        
        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++) {
            if (obj.popCharacter() != obj.dequeueCharacter()) {
                isPalindrome = false;
                
                break;
            }
        }
        
        // finally print whether string s is palindrome or not.
        if (isPalindrome) {
            Console.Write("The word, {0}, is a palindrome.", s);
        } else {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}
