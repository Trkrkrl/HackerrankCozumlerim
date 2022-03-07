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

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
    
      int numberOfSwaps = 0;
        for (int i = 0; i <a.Count; i++) {//dongu a daki eleman sayisi kadar tekrarlansin
        
                  
                    
                    for (int j = 0; j < a.Count - 1; j++) {
                   
                        if (a[j] > a[j + 1]) {//eger a icerisindeki i inci eleman i+1 inci elemandan buyukse yer degistirilir-her degisimde sayac 1 artar
                            
                              int tmp = a[j];
                                a[j] = a[j+1];
                                a[j+1] = tmp;
                                
                                numberOfSwaps++;
                            
                            
                  
                        }
                    }
                    
                    
                        if(numberOfSwaps==0)
                    break;
    
                 
         }
            Console.WriteLine("Array is sorted in " + numberOfSwaps +" swaps.");
                    Console.WriteLine("First Element: " + a[0]);
                    Console.WriteLine("Last Element: " + a[a.Count-1]); 
    }
}
