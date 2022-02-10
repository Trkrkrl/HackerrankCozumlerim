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
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        //convert list to array- list i array e ceevirelim arrayrevers func ile cevirecez direkt
       int[] arts=new int[arr.Count];
        for(var i=0;i<arr.Count;i++){
            arts[i]=arr[i];
            
        }
        
        Array.Reverse(arts);//arrayi reverse ile cevirdik

        foreach (var num in arts)//arrayin elemanlarini yazdiralim
        {
            Console.Write($"{num} ");
        }
        
    }
}
