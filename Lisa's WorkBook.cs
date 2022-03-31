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
    
     n tane bolum var
     arr bize list int veriyor: bunun i inci elemani o bolumde kac tane problem oldugunu gosteriyor
     bolumler yeni sayfada basliyor
     her sayfada k tane problem var
     ancak bolum sonu sayfasinda k dan az problem olabilir
     sayfalar 1 den basliyor
     
     
     yani o  bolumdeki problemlernden birinin nuarasi-o  sayfanin  numarasina esit mi
     
    
     */
//------------------------------------------------------------------------
    public static int workbook(int n, int k, List<int> arr)
    {
        
        int sayfaNo=0;
        int counter=0;
        
        int mevcutBolumSoruSayisi=0;//o bolumdeki soru sayisi
        int soruBaslangic=0;//o sayfadaki soru kactan basliyor
        int sonSoru=0;//o sayfadaki son soru
        
        for(var i =0; i<arr.Count;i++){
            
            mevcutBolumSoruSayisi=arr[i];
            soruBaslangic=1-k;// 1-k kafani kasirsitrmasin while icerisine bak
            sonSoru=0;
            
            while(mevcutBolumSoruSayisi>0){
                 sayfaNo++;
                soruBaslangic+=k;//simsi anlamissindir
                
                if(mevcutBolumSoruSayisi>=k){
                    sonSoru+=k;
                    
                }else{
                    sonSoru+=mevcutBolumSoruSayisi;
                }
                
                if(sayfaNo>=soruBaslangic&&sayfaNo<=sonSoru){//sayfa numaramiz -  o sayfadaki ilk veson soru arasinda ise- yani o sayfadaki sorularndan biri ise ssayac +1
                    counter++;
                    
                }
                mevcutBolumSoruSayisi-=k;
                
            }
           
               
                
            
            
            
        }
         return counter;
        
        
        

    }

}
//----------------------------------------------------------------------------------------
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.workbook(n, k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
