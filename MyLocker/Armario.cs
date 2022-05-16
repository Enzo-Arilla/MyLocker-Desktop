using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class Armario
    {
        [JsonConstructor]
        public Armario(string number, string isRented, string rentedAt, string email, int status)
        {
            Number = number;
            IsRented = isRented;
            RentedAt = rentedAt;
            FK_section_id = email;
            Status = status;
        }

        public Armario()
        {
        }

        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("isRented")]
        public string IsRented { get; set; }
        [JsonProperty("rentedAt")]
        public string RentedAt { get; set; }
        [JsonProperty("FK_section_id")]
        public string FK_section_id { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
