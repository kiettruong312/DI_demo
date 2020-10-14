using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Demo.Services
{
    public class ScopedHandler : BaseHandler, IScopedService
    {
        public void Execute(string hostService)
        {
            base.Log(hostService);
        }
    }
}
