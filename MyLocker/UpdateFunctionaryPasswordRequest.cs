using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyLocker
{
    public class UpdateFunctionaryPasswordRequest
    {

        public UpdateFunctionaryPasswordRequest(string password, string? oldPassword, string cpf, bool forgotPassword)
        {
            this.Password = password;
            this.OldPassword = oldPassword;
            this.Cpf = cpf;
            this.ForgotPassword = forgotPassword;
        }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("oldPassword")]
        public string OldPassword { get; set; }

        [JsonProperty ("cpf")]
        public string Cpf { get; set; }

        [JsonProperty ("forgotPassword")]
        public bool ForgotPassword { get; set; }

    }
}
