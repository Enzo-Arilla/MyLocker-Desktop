using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyLocker
{
    public class Alunos
    {
        [JsonConstructor]
        public Alunos(string ra, string first_name, string last_name, string email, string? code, int? locker_number, int? status)
        {
            Ra = ra;
            First_name = first_name;
            Last_name = last_name;
            Email = email;
            Code = code;
            Locker_number = locker_number;
            Status = status;
        }

        public Alunos(string ra, string first_name, string last_name, string email)
        {
            Ra = ra;
            First_name = first_name;
            Last_name = last_name;
            Email = email;
        }

        public Alunos(string ra, int locker_number)
        {
            Ra = ra;
            Locker_number = locker_number;
        }


        public Alunos()
        {
        }

        [JsonProperty("ra")]
        public string Ra { get; set; }

        [JsonProperty("first_name")]
        public string First_name { get; set; }

        [JsonProperty("last_name")]
        public string Last_name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("locker_number")]
        public int? Locker_number { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

    }

}
