using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI_Demo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DI_Demo.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private ISingletonHandler _singletonService;
        private ITransientHandler _transientService;
        private IScopedService _scopedService;
        private TestService _testService;
        public TestController(TestService testService, ISingletonHandler singletonService, ITransientHandler transientService, IScopedService scopedService)
        {
            _testService = testService;
            _singletonService = singletonService;
            _transientService = transientService;
            _scopedService = scopedService;
        }

        [HttpGet]
        public void Test()
        {
            _singletonService.Execute("");
            _scopedService.Execute("");
            _transientService.Execute("");
            _testService.Execute();
        }
    }
}
