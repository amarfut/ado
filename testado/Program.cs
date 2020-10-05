using Serilog;
using System;

namespace testado
{
    class Program
    {
        static void Main(string[] args)
        {
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
