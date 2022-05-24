
using Microsoft.AspNetCore.Mvc;
using System;

namespace Api_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        [Route("/check-new-api")]
        public bool Check()
        {
            return true;
        }
    }
}
