using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class ChangeApmStatusRequest
    {
        public ChangeApmStatusRequest(int id, int status, string functionaryCpf)
        {
            this.Id = id;
            this.Status = status;
            this.FunctionaryCpf = functionaryCpf;
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("functionaryCpf")]
        public string FunctionaryCpf { get; set; }
    }
}
