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
{/*
bize sayi arrayi verilecek
oyle bir sekilde silme islemi yap ki
en cok sayida kopyai olan eleman kalsin
sildigin eleman sayisini dondur

bir tekrarlana sayi sectirelim for ile
tekrarlalan saiydan daha fazla tekrarlanan varise o olsuntekrarlanan sayi 
tekrarlanma sayaci da olsun


*/



    /*
     * Complete the 'equalizeArray' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int equalizeArray(List<int> arr)
    {//-----------------------------------------------------------------------------------
       arr.Sort();//list elemanlarini siralariz
       
        int n =arr.Count; 
        //n esittri eleman sayisi
        
        // tekrari en cok olan sayiyi  bul
        
        
        int max_count = 1;//max tekrarlananin tekrar sayisi
        int curr_count = 1;//su an uzerinde oldugum eleman in tekrar sayisi
         
        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1]){//eger su anki elemanin aynisi ise
                curr_count++;// su ankinin tekrarini 1 artir
                
            }else{
                     curr_count = 1;//su anki terkrarlanmiyorsa 1
                }
            
            
            //tekrarlari saydik ve artik o sayi tekrarlamiyor-->o zaman                                                     simdilik   en cok tekrarlanan bu
            if (curr_count > max_count)
                {
                    max_count = curr_count;
                
                }
            
        }
     
        // If last element is most frequent
      
        return (arr.Count-max_count);

    }

}//------------------------------------------------------------------------------------------

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
