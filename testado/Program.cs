using Serilog;
using System;

namespace testado
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var arg in args)
            {
                Console.WriteLine(arg);
            }
            
            
            var log = new LoggerConfiguration()
                 .WriteTo.Console()
                 .CreateLogger();

            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                log.Error("Error from console");
                throw;
            }
        }
    }
}
