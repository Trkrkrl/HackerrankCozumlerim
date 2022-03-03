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
     * Complete the 'beautifulDays' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i
     *  2. INTEGER j
     *  3. INTEGER k
     */

    
        
    public static int beautifulDays(int i, int j, int k)
    {//valla yalan yok netten aldim
    //nasil calisiyor bakalim
        var sayac = 0;//oncelikle elbette bir sayac olacak
        //for dongusu ile verilen iki sayi arasindaki her asyiyi isleme sokacagiz
        //once sayiyi string yaptik->reverse fonk var stringlerde-Zsonra da elemanlari array yaptik
        //reversenumber esittirdedik=>parse ile reverse stringten gelen degeri tamsayiyap ve reversenumbera ata
        //reverese string de for dondusunun verdigisayiyi isliyor
        //sonra elde edilen reverselenmis sayiyi kullaniyoz, fark aliyoruz , mutlak fark abs
        //k ile bolumunden kalan 0 ise sayacai bir artir

        for (int sayiDuz = i; sayiDuz <= j; sayiDuz++)
        {
            var reverseString = new string(sayiDuz.ToString().Reverse().ToArray());
            var reverseNumber = int.Parse(reverseString);
            var d = Math.Abs(sayiDuz - reverseNumber);
            var r = d % k;

            if (r == 0)
                sayac++;
        }
        return sayac;

    }
   
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = Result.beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
