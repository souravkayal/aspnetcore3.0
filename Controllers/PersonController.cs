using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("[action]")]
        public async Task<String> GetPerson() 
        {
            String value = "code added in develop branch";
            String anotherValue = "Other line added1";


            return "fun";
        }

    }
}
