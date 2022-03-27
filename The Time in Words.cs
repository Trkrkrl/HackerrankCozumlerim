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
     * Complete the "timeInWords" function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER h
     *  2. INTEGER m
     */
//-----------------------------------------------------------------------
    public static string timeInWords(int h, int m)
    {/*
    sayilari kelime olarak verelim
    ikinci asamada 00 ve 30 isin ozel 
    00 dan 30 a kadar isin ayri sonrais isin ayri 
    
    
    */
    string[] nums ={"","one","two","three","four","five","six","seven","eight",
    "nine","ten","eleven","twelve","thirteen","fourteen","quarter",
    "sixteen","seventeen","eighteen","nineteen", "twenty", "twenty one",
     "twenty two", "twenty three", "twenty four", "twenty five","twenty six",
      "twenty seven", "twenty eight", "twenty nine", "half"};//tüm dakikalari yazdik
    
    string inWords="";
    
    if(m == 0){// dakika 0 da oclock
        inWords = (nums[h] + " o\' clock");
    } else if(m == 1) {
        inWords = (nums[m] + " minute past " + nums[h]);//01 dkda minute
    } else if(m == 15 || m == 30) {
        inWords = (nums[m] + " past " + nums[h]);//15 gece ve 30 gece de  minute yok
    } else if(m == 45) {
        inWords = (nums[60-m] + " to " + nums[h+1]);//45 ise 60 - 45  kala , saatide bir ust saat
    } else if(m < 30) {
        inWords = (nums[m] + " minutes past " + nums[h]);//normal gece dakikalar
    } else {
        inWords = (nums[60-m] + " minutes to " + nums[h+1]);//normal kala dakikalar
    }
    return inWords;

    }

}//-------------------------------------------------------------------------------------

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int h = Convert.ToInt32(Console.ReadLine().Trim());

        int m = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.timeInWords(h, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
