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
     * Complete the 'designerPdfViewer' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h
     *  2. STRING word
     */

    public static int designerPdfViewer(List<int> h, string word)
    {//harflerin num karsiliklari  verilecek-bu input ile hazir gelecek
    //bir listchar yapisi yapsak kendi listemizdeki harfin sira sayi numarasaii ye karsilik gelen i inci elemanin h listesindeki karsiligina bakariz
    //bunu word icerisindeki her eleman a for ile yapariz 
    //enbuyuk= if ile yeni gelen nuyuk deriz
        //wordun harfleri secilecek
        //wordun eleman sayisi alinacak
     //secilen harfler in sayi karsiliklarindan buyuk olan secilecek
     //eleman sayisi carpi buyuksayicarpilacak
      //List<char> alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToList();
      List<char> alphabet = new List<char>(){'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};//alfabe yazdik list olmasi daha iyi olur
      
      char[] wordChar = word.ToCharArray();//kelimeyi char lar dan olusan bir arraye cevirdik
      int enBuyukH=0;//kelime icerisindeki en buyuk boya sahip olan eleman boyu
      var area52cokkomik=0;//sonuctaki alan
      var kelimeCharSayisi=wordChar.Length;//kelime uzunlugu
      
      for( var i=0;i<wordChar.Length;i++){//kelimedeki her i inci elemanin alphabetteki sira sayisini bulmamiz gerek
           
           var icIndex=alphabet.IndexOf(wordChar[i]);
            
            if(enBuyukH<h[icIndex]){
            enBuyukH=h[icIndex];
             
         }
         
        
          
          
         }
         area52cokkomik=kelimeCharSayisi*enBuyukH;
         return area52cokkomik;
      
      
      
     

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

        string word = Console.ReadLine();

        int result = Result.designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
