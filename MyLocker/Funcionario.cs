using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class Funcionario
    {
        [JsonProperty("cpf")]
        public string Cpf { get; set; }
        [JsonProperty("first_name")]
        public string First_name { get; set; }
        [JsonProperty("last_name")]
        public string Last_name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
