using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
       // kac kelime girilecegini verecek
       //kelimenin cift ve tek siranolu indislerini ayir
       var n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            var str = Console.ReadLine();//satiri oku ve str ye ata

            for (var j = 0; j < str.Length; j++)
            {
                if (j % 2 == 0) Console.Write(str[j]);
            }

            Console.Write(" ");//kelime icerisindeki tek ve cift arasi ayrim

            for (var j = 0; j < str.Length; j++)
            {
                if (j % 2 != 0) Console.Write(str[j]);
            }

            Console.Write(Environment.NewLine);//kelimeler arasi satir atla
       }
    }
}
