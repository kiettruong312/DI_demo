﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Demo.Services
{
    public interface ISingletonHandler
    {
        void Execute(string hostService);
    }
}
