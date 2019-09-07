using System;
using System.Threading;
using System.Threading.Tasks;

namespace dottraceexample.Services
{
    public class SlowService : ISlowService
    {
        public SlowService()
        {
            Console.WriteLine("create instance of SlowService");

            Thread.Sleep(TimeSpan.FromSeconds(10));
            
            Console.WriteLine("completed instance creation");
        }

        public async Task<int> GetNumberAsync()
        {
            Console.WriteLine("Calling GetNumber of SlowService");
            
            Thread.Sleep(TimeSpan.FromSeconds(1));

            return 1;
        }
    }
}