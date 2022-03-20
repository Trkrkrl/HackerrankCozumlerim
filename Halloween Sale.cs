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
{/* ilk urun p dolar
    sonrakile - d azalarak gidiyor 
    eger bu m den asagi gider ise m en alt sinir  olarakl kabul ediliyor
    sonrakiler hep m dolar
    Butce = s
    

     */

    public static int howManyGames(int p, int d, int m, int s)
    {//-------------------------------------------------------------------------------------------------------------------------
       int budget=s;
       int alinanOyunSayisi=0;
       int guncelFiyat=0;
       
       if(budget<p){
           return 0;
       }
       
       while(budget>=m){//budget-p>p-d guncel fiyat
           
           if(alinanOyunSayisi<1){//ilk oyun alinir-fiyat duser-butceden p duser
               
               alinanOyunSayisi++;
               guncelFiyat=p-d;
               budget=budget-p;
               
               
           }else if(alinanOyunSayisi>=1){//ilk oyundan sonra burasi calisir
               
               if(budget<guncelFiyat){//eger il oyun alimindan sonra butce ikinci oyuncagi almaya yetmezse 1;
                   return alinanOyunSayisi;
               }
               
               
               if(guncelFiyat>m){//fiyatimiz m ye inene kadar burasi calisir
                   
                   alinanOyunSayisi++;
                   
                   budget=budget-guncelFiyat;
                   guncelFiyat=guncelFiyat-d;
                   
               }else if(guncelFiyat<=m){//fiyat m ye esitlenir veya altina duser se burasi  m fiyatiyla calisir
                   alinanOyunSayisi++;
                   
                   guncelFiyat=m;
                   budget=budget-guncelFiyat;
               }
           }
       }
       return alinanOyunSayisi;
    //-------------------------------------------------------------------------------------------------------------------------
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int p = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        int m = Convert.ToInt32(firstMultipleInput[2]);

        int s = Convert.ToInt32(firstMultipleInput[3]);

        int answer = Result.howManyGames(p, d, m, s);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
