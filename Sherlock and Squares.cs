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
     * Complete the 'squares' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER a
     *  2. INTEGER b
     */

    public static int squares(int a, int b)
    {//-----------------------------------------------------------------------------------------
        /* a ve  b sayisi arasinda -a ve b dahil- kac tane karekokuolan sayi var
        oncelikle a ve b neyin kareleri- kusuratsiz bulmak gerek
        a ve b kusuratli bir sayinin karesi ise - a-->bir usttekis kok olan sayidan itibaren
        b bir alttaki kok olan sayidan itbaren
        
        
        */
        
        
       var altKok=Math.Ceiling(Math.Sqrt(a));//a nın koku olan sayinini bir ustundeki tamsayidan itibaren
       var ustKok=Math.Floor(Math.Sqrt(b));// b nin koku olan sayinin altindaki ilk tam sayiya kadar
       
       
       var koklerarasifark=ustKok-altKok+1;//neden +1: 4 il 9 arasi dusun 9-4=5 , 4,5,6,7,8,9 arada dahil 6 rakam var ondan +1
       return (int)koklerarasifark;
       //-------------------------------------------------------------------------------------------------------
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(firstMultipleInput[0]);

            int b = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.squares(a, b);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
