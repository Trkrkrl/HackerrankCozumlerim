using System;
public interface AdvancedArithmetic{
    int divisorSum(int n);
}
//--------------------------------
public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int sum =0;
        //n sayisini i ye bol kalani yoksa tam boluyordur
        for(var i=1;i<=n;i++){//1 den baslatacaksin
            if(n%i==0){
                sum=sum+i;//bolen sayivarsa toplama ekle
                
            }
        }
        return sum;
    }
}
//------------------------------------
class Solution{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
    }
}
