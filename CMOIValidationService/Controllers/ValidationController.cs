using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Validator;

namespace CMOIValidationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return Startup.StartupTime.ToString("yyyy/MM/dd HH:mm:ss");
        }


        // POST api/values
        [HttpPost]
        public string Post([FromBody] byte[] value/*byte[] value*/)
        {
            if(value.Length == 0 )
                return "false";

            string msg = Encoding.UTF8.GetString(value);
            ValidationModels.ValidationRequest request = JsonConvert.DeserializeObject<ValidationModels.ValidationRequest>(
                msg, new ProtoMessageConverter());

            bool result = ValidationProcessor.Instance.ValidateUser(request);
             if (result == true)
             {
                 Response.StatusCode = 200;
                 return "true";
             }
             
             Response.StatusCode = 401;
             return "false";
        }


    }
}
