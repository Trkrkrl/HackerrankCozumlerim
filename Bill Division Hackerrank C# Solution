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
     * Complete the 'bonAppetit' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY bill
     *  2. INTEGER k
     *  3. INTEGER b
     */

    public static void bonAppetit(List<int> bill, int k, int b)
    // anna nin yedikleri vs brian yedikleri
    //anna yenilen tutar vs brians yenilen tutar
    { List<int> annaslist= new List<int>();
    List<int>  Brianslist=new List<int>();
    
    annaslist=bill;//annanin listesini billden gelenlere esitle
    annaslist.RemoveAt(k);//[k] cikar->annnain guncel listesi
    int sumAnna=0;//anna toplam
    
    for (int i = 0; i < annaslist.Count; i++)//topla anna nin yedigi herseyin fiyati
            {sumAnna+=annaslist[i];

            }
            
    int annaOdeyecek= (sumAnna/2);//anna yediklerinin yarisini odeecek
    int brianBorc=(b-annaOdeyecek);//berian in istedigi eksi annanin odemesi gereken
    
            if (b==annaOdeyecek)
            { Console.WriteLine("Bon Appetit");


            }
            else
            Console.WriteLine(brianBorc);
 
    
            

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        Result.bonAppetit(bill, k, b);
    }
}
