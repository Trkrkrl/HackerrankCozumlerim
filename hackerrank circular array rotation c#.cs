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
     * Complete the 'circularArrayRotation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER k
     *  3. INTEGER_ARRAY queries
     */
//------------------------------------------------------------------------------------------------------------------------------
    public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
    {//oncelikle soruyu anlamamaniz normla cunku anlatim yanlis istediği sey ile  anlattigi  farkli
    //verdigi ornek e gore yaparsak
    // 0+k=2,1+k=3(mod alinca 0),2+k=4(mod alinca 1)oldu
    //yani yukraidakine gore
    //a0 yani 1->arr[2]'ye gidecek
    //a1- yani 2>arr[0] ' a gidecek
    //a2 yani 3->arr[1]'e gidecek
    //buna gore a={2 1 3 }
    olacak
    
    //inputun ilk satiri n : dizideki sayi sayisi,k: rotasyon sayisi , q querry sayisi
     // ikinci satirda n tane elemandan olusan sayi dizisi
     // diger  satirlar da yeni dizide istedigi elemanin indis no su
     //
     int n=k%a.Count;//k buyuk ise mod u  al yeterli
     
      int[] arr = new int[a.Count];// yeni bir int dizisi olustur ve boyutu a kadar olsun
                        
            for(int i=0 ; i<a.Count ; i++){
                //elemanlari i+k kadar kaydirmamiz gerrekecek, mesela i 0 k da a dan kucuk (k.inci indisteki)eleman yeni al elemani
                //i =1 mesela
                //burada k dizi boyutundan buyuk olabilir , mod alaalim 
            
                arr[(i+n)%a.Count] = a[i];
            }                 
            for(int i=0 ; i<queries.Count ; i++){
                
            
                queries[i] = arr[queries[i]];
            }                 
            return queries; 
        
    }
    
      //--------------------------------------------------------------------------------------------------------------------------   

    

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int q = Convert.ToInt32(firstMultipleInput[2]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> queries = new List<int>();

        for (int i = 0; i < q; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
            queries.Add(queriesItem);
        }

        List<int> result = Result.circularArrayRotation(a, k, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
