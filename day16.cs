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



class Solution
{
    public static void Main(string[] args)
    {
        string S = Console.ReadLine();
        //Bu problem diyor ki: bir string array ile stringler girecek
        //gelen bu stringler icerisinde sayi olanlar olacak
        //bunu try ve catch ile yap
        //int-sayi iceriyor mu  kontrolu yap
        //sayiya ceviremezsen badstring diye yazdir
        
        
        
          var str = Console.ReadLine();

        try
        {
            int num = int.Parse(S);//parse : degiskenTuru.Parse(donusturulecek deger)-string to int32 diye kullanilir
            
            Console.WriteLine(num);
        }
        catch (Exception)
        {
            Console.WriteLine("Bad String");
        }
        
    }
}
