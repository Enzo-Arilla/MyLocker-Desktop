using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyLocker
{
    public class GenerateFunctionaryVerificationCodeResponse
    {

        public GenerateFunctionaryVerificationCodeResponse()
        {

        }

        public GenerateFunctionaryVerificationCodeResponse(string randomCode)
        {
            this.RandomCode = randomCode;
        }

        [JsonProperty ("randomCode")]
        public string RandomCode { get; set; }
    }
}
