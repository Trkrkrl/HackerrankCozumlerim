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



class Solution//kendim cozmedim-baskasinin cozumu uzerine cozumleme ve aciklama yaptim, ancak anladim
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());//bize girdi string array olarak geliyor, int'e cevirelim
        
        

        var sum = 0;
        var max = 0;

        while (n > 0)
        {
            if (n % 2 == 1)//2ye bolumden kalan 1 ise 1 gelir , sum u artiririz
            {
                sum++;

                if (sum > max)
                    max = sum;
            }
            else sum = 0;//2 ye bolumden kalas sifir ise-sifir sayisi geleceginden yanyana bir ler resetlenir

            n = n / 2;//her turda 2 ye bolumnde kalan soruyoz, boldugumuzu belirtelim o zaman
        }

        Console.WriteLine(max);//yan yana gelen 1 lerin max sayisi
    }
    
}
