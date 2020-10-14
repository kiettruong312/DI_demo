using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Demo.Services
{
    public class BaseHandler : IBaseHandler
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int Count { get; set; } = 0;

        public void Log(string hostService)
        {
            if(Count == 3) { return; }
            LogHostService(hostService);
            Console.WriteLine($"{this.GetType().Name} - {Id}");
            Count++;
        }

        private void LogHostService(string hostService)
        {
            if (!string.IsNullOrEmpty(hostService)) 
            {
                Console.Write($"{hostService} - ");
            }
        }
    }
}
