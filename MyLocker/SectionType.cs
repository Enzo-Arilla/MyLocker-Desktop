using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class SectionType
    {
        [JsonConstructor]
        public SectionType(int id, string color, string left_room, string right_room, int status)
        {
            Id = id;
            Color = color;
            Left_room = left_room;
            Right_room = right_room;
            Status = status;
        }

        public SectionType()
        {
        }

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("left_room")]
        public string Left_room { get; set; }
        [JsonProperty("right_room")]
        public string Right_room { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
