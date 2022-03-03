using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}
//---------------------------------------------------------------------start of coding------------------------------------------

//yukaridaki person a ait(parantezdeki 3 paramtreye sahip bir studen class olusturalim)
//ek olara teskorlari arrayi girecek girdi olarak
class Student : Person{
    private int[] _testScores;  
  
    //bir nevi ctor : yapiyi anlaamdim aslisik oldugum bisey degil
    // bu student classimiz su paramterelere sahip olacaktir
    //base anahtar sozcugu turetilmis bir sinif icerisinden temel sinifin uyelerine erismek icin kullanilir. student class'i person class'ini base aldiktan sonra, person class'i base anahtar sozcugu ile cagirir
    //normailde interface ile yapariz
    public Student(string firstName, string lastName, int identification, int[] testScores) : base(firstName, lastName, identification)
    {
        _testScores = testScores;
    }

    public char Calculate()//harf notu hesabi :if else ile yapilacak, toplam bolu ort ve bu methodun donusu char  yani tek karakter olacak
    {
        int total = 0;

        foreach (int testScore in _testScores) //test cores arraydeki tum degerleri topla 
        {
            total =total + testScore;
        }

        int avg = total / _testScores.Length;//toplam notun toplam not sayisina bolumuu oratalamayi verir

        if (avg >= 90 && avg <= 100){
           return 'O'; 
        } 
        
        else if (avg >= 80 && avg < 90){
           return 'E'; 
        } 
        
        else if (avg >= 70 && avg < 80){
            return 'A'; 
        }
        
        else if (avg >= 55 && avg < 70){
           return 'P'; 
        } 
        
        else if (avg >= 40 && avg < 55){
            return 'D';
        } 
        else return 'T';
        
        
    }
}
//---------------------------------------------------------------------end of coding-------------------------------------------

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}
