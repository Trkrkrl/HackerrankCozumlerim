int maxDistance = 0;
    
        int geciciMax = 0;//gecici max
        int f=0;
        int s=0;
        
        
        int len = c.Count();//c deki eleman sayisi
        
    
        Array.Sort<int>(c);//c yi sirala
        
        //case 1
        if(n == len){// c de n tane eleman varsa her sehirde istasyon vardir
            return 0;
        }
        
        //case 2-  c de 1 tane istasyon var ise  
        if(len == 1){
            
            if(n-1 - c[0] > c[0]){// n-1 indis gibi dusun, n den cyi  cikardin -   kalan c den buyukse mesafe kalandir yani n-1-c
                return n-1-c[0];
            }
            else{
                return c[0];
            }
        }
        
        //----------c 0 veya 1 elemanli degilse burdan sonrasi calismaya baslar
        if(c[0] > maxDistance)
            {
                maxDistance = c[0];
            }
        
                        //case 3
                        
                        for(int m=0; m < len-1; m++){
                                    
                                f = c[m];
                                s = c[m+1];
                                
                                if(s - f == 1){//c icerisinde herhangi iki sayi ardisiksa devam et
                                    continue;
                                }
                                
                                //ardisik degilse
                                
                                geciciMax = (s - f - 1)/2 + (s-f-1)%2;//farkin 2 ye bolumu +  kalan
                                //yani max c sayilari arasi farktir- ki mantikli
                                if(geciciMax > maxDistance){
                                    maxDistance = geciciMax;
                                }
                                                        
                            
                        }
                        
                        //case 4- n den c nin en buyuk elemamini cikardik- bu c0 dan buyuk ise- bu aradaki farktir
                        if(n - c[len-1] - 1 > maxDistance){
                            return n-c[len-1]-1;
                        }
               
        
        return maxDistance;
