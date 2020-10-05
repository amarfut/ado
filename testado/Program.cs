using System;

namespace testado
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Step 1");
            
            throw new Exception("Exception from utility");
            
            Console.WriteLine("Step 2");
        }
    }
}
