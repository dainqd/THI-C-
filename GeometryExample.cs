using System;


namespace calc{
    class CalcForula{
       public static void Main1(string[] args)
       {  
        const double pi = 3.14159;    
        int radius;
        int height;
        double BaseArea;
        double LateralArea;
        double TotalArea;
        double Volume;
        Console.WriteLine("Enter radius: " );
            radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height: " );
            height = Convert.ToInt32(Console.ReadLine());
            BaseArea = radius * radius * pi;
            LateralArea = 2 * pi *radius * height;
            TotalArea = 2 * pi * radius * (height+radius);
            Volume = pi * radius * radius * height;
            Console.WriteLine("Cylender Characteristics");
            Console.Write("Radius :"+radius);
            Console.WriteLine(", Height :"+height);
            Console.Write("Base :"+BaseArea);
            Console.Write(" | Lateral :"+LateralArea);
            Console.Write(" | Total :"+TotalArea);
            Console.Write(" | Volume :"+Volume);
            

       }
    }
}
