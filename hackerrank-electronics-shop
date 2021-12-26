using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b) {
       
        int tutar=0;//dongude yapilan secim sonucunda o anki tutar olacak
        int tutKlavye=0;
        int tutDrive=0;
        var maxTutar=-1;//baslangic olarak -1 yani karsilamiyor olarak kalsin
        //ic ice for dongusu
        //bu dongu ile klavye ve drive serilerindeki tum elemanlar caprazlanacak
        //
        for(int i=0;i<keyboards.Count();i++){
            tutKlavye=keyboards[i];
            
              for (int j=0;j<drives.Count();j++){
                    tutDrive=drives[j];
                    //buraya tutar i yazariz burada tum elemanlar caprazlanmis oluyor-her bir dongu bittiginde ayri bir deger yani
                     tutar=tutKlavye+tutDrive;
                    
                    if(tutar<=b){//o anki dongu sonucunda eger bir onceki degerden buyuk ise yeni degeri set ediyor,
                        if(tutar>maxTutar){
                            maxTutar=tutar;
                        }
                    }
                };
          
        };
        //tum donguler bitince de en son en buyuk ne verdiyse maxtutar a onu aliyor
        return maxTutar; 
                    
       
        
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
