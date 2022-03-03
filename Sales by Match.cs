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
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {var gecici=new List<int>();//yeni bir bos liste yaratilir
     var ciftSayac=0;//sayac
        foreach (var item in ar)
        {
            
            if (gecici.Contains(item) )
            {
                gecici.Remove(item);
                ciftSayac++;
            }
            else
            gecici.Add(item);
            //

        }//bu dongu sayesinde, ilktur bos gecer ve diger listedeki ilk elemani ekler
        //bir sonraki turda eger yeni listedeki eleman eski listenin siradaki elemanina esitse bir cift oalrak sayilir, yeni listedeki o eleman silinir, ilk listedeki o elman eklenmez ve sayac artirilir.
        return ciftSayac;
    }

}



class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
