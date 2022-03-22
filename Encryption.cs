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
     STRiNGDEKi BOSLUKLARi KALDiRiNCA  KAC KARAKTER  ORNEGiN 54--> sqrt 54  7 VE 8 arasinda 7 satir 8 sutun
     ayrica row ve column sayisi yani 7/8 >=L olmali
     
     once bosluklari cikarmaliyiz
     karakter saymaliyiz-->L
     sqrt L-->bunu yuvarlama ile bir ust bir alt alip  taban=satir,  tavan=sutun olacak sekilde atayalim
     
     aciklama cozumun uzerinde
     not: bizden satir satri cikti istemiyor birer boslukla yan yana stringler isityor
     
   
     
     */

    public static string encryption(string s)
    {s = Regex.Replace(s, @"\s", "");//bosluklari hic ile degistiri , yok olur bosluklar
        
     int L=s.Length;
     int rowSayisi=Convert.ToInt32(Math.Floor(Math.Sqrt(L)));
     int colSayisi=Convert.ToInt32(Math.Ceiling(Math.Sqrt(L)));
     
    
                    string result="";//bir string donecez o yuzden bu
                    
                    for(int i=0;i<colSayisi;i++)//saga dogru karakter sayisi
                    {
                        for(int j=i;j<L;j+=colSayisi){//i den baslama sebebi, direkt i nin altindan ikinci satirdan baslar
                                                        //+colsayisi ile bir altsatirdeki yeri
                           result += s.Substring(j,1);//o satirdaki harfleri yani j ye denk gelenleri reuslt a ekliyo
                        }  
                            result += " ";//sonuna da bolsuk ekle
                    }
                    return result;
    

    }
//-----------------------------------------------------------------------------------
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
