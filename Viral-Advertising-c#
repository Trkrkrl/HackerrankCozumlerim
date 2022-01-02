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
     * Complete the 'viralAdvertising' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int viralAdvertising(int n)
    {//1.gun sharedin yarisinin asagi yuvarlanmi sayisi=liked olacak
    //cumulative = liked +cumulative olarak gidecek
    ///yeni gundeki shared= onceki gunki liked *3
    //liked sadece o gnki shared in yarisi, degismiyor: dongu icerisnde kalsinler dongude yeniden tanimlasnins
    //ilk paylassim sayisi  belli
    // gun sayisi veirlecek sadece o gun sonu sayi
    var liked=0;
    var dayNumber=n;
    var cumulative=0;
    var shared=5;
    
        for(int i=0;i<dayNumber;i++){
            
            liked=(int)Math.Floor((decimal)shared/2);// burada floor yapisi kullaninca  decimal ve int i yazmak gerek hata veiryor yoksa-cast yapisi
            cumulative=cumulative+liked;//yeni kumulatif eskisi arti eklenen like
            
            
            
            
            
            
            shared=liked*3;//artik paylasim sayisi liked in 3 kati
            
        }
    return cumulative;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.viralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
