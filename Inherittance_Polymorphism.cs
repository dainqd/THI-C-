using System;
 
 namespace demoInher_Poly{
        
        
    class show{
        public string name;
        public int weight;
        public show(){
            this.name = name;
            this.weight =weight;
        }
    }
    class Lion : show{
        // public Lion(){

        // }
    }
    class Tiger : show{
        
    }
    public class testproduct{
    public static void Main(string[] args)
    {
        Lion lion1 = new Lion();
        lion1.name= "Lion";
        lion1.weight= 100;
        Console.Write("Name : "+lion1.name);
        Console.WriteLine(", Weight : "+lion1.weight);
        Tiger tiger1 = new Tiger();
        tiger1.name= "Tiger";
        tiger1.weight= 200;
        Console.Write("Name : "+tiger1.name);
        Console.WriteLine(", Weight : "+tiger1.weight);
    }
 }
 }