using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    
    public static void Main(String[] args) {
        
       var n = int.Parse(Console.ReadLine());//baslangicta verilen deger, kac tane satir
        var telKayitlari = new Dictionary<string, int>();//bir  dict  yapsii olusturalim

        for (var i = 0; i < n; i++)
        {
            var entry = Console.ReadLine().Split(' ');//satir girdisini okuyalim ve ayiralim
            var isim = entry[0];//girdinin ilk elemani  
            var telNo = int.Parse(entry[1]);//girdinin ikinci elemani ise telno
            telKayitlari.Add(isim, telNo);//bunlari dict e ekle
        }

        for (var i = 0; i < n; i++)//devaminda gelecek satirlar bize isim verecek numara  soracak
        {
            var isim = Console.ReadLine();//satiri oku
            if (telKayitlari.ContainsKey(isim))//o  satirdaki isime denk gelen bir key varmi
            {
                var telNo = telKayitlari[isim];//var ise bu isimdeki tel kaydini ver
                Console.WriteLine($"{isim}={telNo}");//bu sekilde yazdir
            }
            else Console.WriteLine("Not found");
        }
    }
}

