using System;

namespace Fucktorial
{
    class Program
    {
        static int Fucktorial (int x)
        {

            if (x == 1) { Console.Write(x + " = "); }
            else { Console.Write(x+"*"); }
            int result = 1;
            
            if (1 < x)
            {
                result = result * x;
                x--;
                Fucktorial(x);    
            }
            return result;
        }


        static void Main(string[] args)
        {
            ////factorial with "for"
            Console.WriteLine("Fucktorial?");
            int x = int.Parse(Console.ReadLine());
            int result = 1;
            Console.Write(x + "! = ");
            for (int i = 1; i <= x; i++)
            {
                Console.Write(i);
                if (i < x) { Console.Write("*"); }
                if (i == x) { Console.Write(" = "); }
                result = result * i;
            }
            Console.Write(result);
            Console.WriteLine();

            
            //Fucktorial recursion style
            ////         But how do i get result?
            Fucktorial(int.Parse (Console.ReadLine()));
            

        }
    }
}
