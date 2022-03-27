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
     * Complete the 'minimumDistances' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */
//------------------------------------------------------------------------------------

    public static int minimumDistances(List<int> a)
    {/* verilen seri icerisinde ayni rakama sahip olan 1 ve 2 nci elemaninin indislerini bul
        farklarini al
        eger baska herhangi esit iki elemanin indisleri arasi,daki fark kucuk ise yeni fark odur
    */
        int result = -1;//Eslesme yok ise -1
        
        foreach (int num in a) {//a icerisindeki her sayi isin
            
            int pos1 =a.IndexOf(num);// o sayiya ait  index ve son index
            int pos2 =a.LastIndexOf(num);

            if (pos1 != pos2) {//indexlerin sirasi ayni olmamak kosulu saglaniyor ise
            
                int dist = pos2 - pos1;//mesafe = farklari
                
                if ( (result == -1) || (result > dist) ) {//result bastaki -1 ise veya onceki dist simdikinden buyuk ise
                    result = dist;
                }
            }
        } 
        return result;
    }

}
//------------------------------------------------------------------------------------
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
