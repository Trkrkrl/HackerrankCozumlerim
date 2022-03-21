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
    kutularda toplari var
    her renk bir kutuda olmak zorunda
    yerlerini swap-degistirerek her rengi bir kutuya almak istiyor
    tek sferede sadece 1 topu diger kutdaki ile yer degistirebiliyor
    eger imkansiz ise imppossible yazdir
    
    2 boyutlu dizi gibi dusun
    listelerin listesini vercek bize
    
    yani her satir kutunumarasi demek
    her sutun top tipi demek
    1.satir 1.sutunda 5 yaziyosa mesela:1.kutuda -sifirinci indis yani -  5 tane 0sifirinci tipten top var
    
    muhtemelej soyle yapacagiz  0 inci satin 1 inci sutunda ki eleman sayisi sifirdan buyuk ve esit mi 1incisatir 0  inci sutun-->esit ise  0,0 i artirip  0,1 den 1 azaltacagiz
    
    
     * Complete the 'organizingContainers' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts 2D_INTEGER_ARRAY container as parameter.
     
     */

    public static string organizingContainers(List<List<int>> container)
    {
        HashSet<int> kutular = new HashSet<int>();//hashsetler kumeleme yapar ,ekledigin sirada kallir ,oto siralama yapmaz
        HashSet<int> tipler = new HashSet<int>();
        
        for (int i = 0; i < container.Count; i++)
        {
            int balls = 0;
            int size = 0;
            
            for (int j = 0; j < container[i].Count; j++)
            {//
                size += container[i][j];// sabit olan i inci satirda ki butun sutunlari toplar-> 0,0- 0,1 - 0,2 - 0,3
                balls += container[j][i];// her bir j inci satirin 0 inci kolonunu toplar  ->0,0 -1,0 -2,0 -3,0
                
               
            }
            kutular.Add(size);//ornegin ilk turda i=0 inci satirdaki tum elemanlar toplamini burada ilk siraya ekle
            
            tipler.Add(balls);//0(i) inci sutunda tum satirlarin toplamini burada ilk siraya ekle
           
        }
        return kutular.SetEquals(tipler) ? "Possible" : "Impossible";      //peki neden set grubuna ait set equals?-  setler esitlige bakarken basit dusunur, list gibi  harf duyarliligi gibi aptal seylere takilmaz

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
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> container = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                container.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(containerTemp => Convert.ToInt32(containerTemp)).ToList());
            }

            string result = Result.organizingContainers(container);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
