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
        public Armario(int number, int isRented, string rentedAt, int fk_section_id, int status, SectionType section)
        {
            Number = number;
            IsRented = isRented;
            RentedAt = rentedAt;
            FK_section_id = fk_section_id;
            Status = status;
            Section = section;
        }

        public Armario()
        {
        }

        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("isRented")]
        public int IsRented { get; set; }
        [JsonProperty("rentedAt")]
        public string RentedAt { get; set; }
        [JsonProperty("FK_section_id")]
        public int FK_section_id { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("section")]
        public SectionType Section { get; set; }
    }
}
