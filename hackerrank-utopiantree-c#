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
     * Complete the 'utopianTree' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int utopianTree(int n)
    {//eger cift sayi ise  mod al yarisi kadar o islemden yap
    //cift degilse n-1 tane /2 tane islem yap sonra tekil islemi ekle
    
        int boyIlk=1;
        
        if(n%2==0){
            for(int i=0;i<n/2;i++){
                boyIlk=boyIlk*2;
                boyIlk=boyIlk+1;
                
            }
        }
        if(n%2==1){
            for(int i=0;i<(n-1)/2;i++){
                boyIlk=boyIlk*2;
                boyIlk=boyIlk+1;
                
            }
            boyIlk=boyIlk*2;
            
        }
        return boyIlk;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
