using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Demo.Services
{
    public class SingletonHandler : BaseHandler, ISingletonHandler
    {
        public void Execute(string hostService)
        {
            base.Log(hostService);
        }
    }
}
