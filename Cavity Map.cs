public static List<string> cavityMap(List<string> grid)
    {   
        int gridSayisi = grid[0].Length;
        
        List<string> returnList = grid;
        
        for (int i = 1; i < gridSayisi - 1; i++)
        {
            var icMatris = grid[i].Substring(1, gridSayisi - 2);//substring stringin 
                                                                //parcasini alir-basindex ve uzunluk
                                            //-2  olmasinin sebebi bir sag bir de sol kenarini katmamak
                                            //inceleme yapacagimiz ic matrisi aldik
            for (int j = 0; j < icMatris.Length; j++)
            {
                //ust ,alt ,sag ve sol daki komsu sayilara komsu dedik
                var komsu = grid[i - 1][j + 1];
                var komsu2 = grid[i][j];
                var komsu3 = grid[i][j + 2];
                var komsu4 = grid[i + 1][j + 1];
                
                //eger tum komsulardan buyukse daha derindedir ve x tir
                //inner j su an baktigimiz sayi
                if (icMatris[j] > komsu && icMatris[j] > komsu2 && 
                    icMatris[j] > komsu3 && icMatris[j] > komsu4)
                {
                    char[] chars = returnList[i].ToCharArray();
                    chars[j + 1] = 'X';//cukur olan elemani x  olarak degistir
                    
                    var newString = new string(chars);//arrayin yeni halini stringe ata
                    
                    returnList[i] = newString;//yeni stringi de son list e ekle
                }
            }
        }
        
        return returnList;
