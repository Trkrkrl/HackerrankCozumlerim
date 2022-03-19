using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
    once eleman sayisi kontolu yapilacak aradaki fark k dan buyuk ise  no donulecek
    aradaki farki bulmak ? ilk elemandan baslayarak esitler mi kontrolu
    esit olmayan n indexini al ilk stringin so indexinden cikar
    bu silinmesi gereken harf sayisi
    
    2. elemanin sonn ortak nokadan itibaren son indise kadar kactane var
    son indis - ortakson 
    bu sayi da ekleme yapialarak kactane gereklii oldugunu verir
    
    sonra esitler mi diye bakilacak-evet ise yes
    degil ise 
    
    burada ek olarak k nin tamamini kullanilmasini istiyor
    Bu durumda k ve arraylerin elemanlari toplami cift iseler  sikinti yok
    
    
    -*/

    public static string appendAndDelete(string s, string t, int k)
    {
        //stringi char arraye cevir
        char[] charArr1=s.ToCharArray();
        char[] charArr2=t.ToCharArray();
        
        
        int sonOrtakIndis=0;
        
        int ilkinSonu=charArr1.Count();
        int ikinciSonIndis=charArr2.Count();
        int farklarToplami=0;
        
        string noText="No";
        string yesTxt="Yes";
        
        //hangi array uzun ise digerinin eleman sayisi kadar ilerle
        //ortak olduklari son noktayi bul
        if(charArr1.Count()>=charArr2.Count()){
            
            sonOrtakIndis=charArr2.Count();
            
                for  (int i=0;i<charArr2.Count();i++){
                
                    if(charArr1[i]!=charArr2[i])
                    {sonOrtakIndis=i;
                     break;
                        
                    
                    }
                    
                
                }
        }else if(charArr1.Count()<charArr2.Count()){
            
            sonOrtakIndis=charArr1.Count();
            
                for  (int i=0;i<charArr1.Count();i++){
                
                if(charArr2[i]!=charArr1[i])
                {sonOrtakIndis=i+1;
                    break;
                }
                
                
            }
            
         }
       
        farklarToplami=(ilkinSonu+ikinciSonIndis-(2*sonOrtakIndis));
       
        
        if(farklarToplami>k){
           return  noText;
        }else if(farklarToplami%2==k%2&&farklarToplami<=k){
            return yesTxt;
        }else if(ilkinSonu+ikinciSonIndis<k){//iki arrayin elemanlari toplami k dan buyuk ise zaten yes
            return yesTxt;
            
        }else
        return  noText;
        
     
        

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
