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



    public static List<int> cutTheSticks(List<int> arr)
    {
        var list = new List<int>();
        
        while (arr.Count > 0)
        {
            list.Add(arr.Count);//eleman sayisini listeye ekle
            arr = arr.Select(x => x - arr.Min()).Where(x => x > 0).ToList();
             //yeni arr= arr nin tum elemanlarindan arr.min i cikar =kosul olarak elemanlar sifirdan buyuk  
             //whwere ksoulu vermesssen calismaz 
        }
        return list;//bizimm listemizde eleman sayilari liste sekilnde var
        //asagidaki fonksiyon bunlari alip satir satir yazacak
                
        
        

    }

}/---------------------------------------------------------------------------------------------

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.cutTheSticks(arr);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
