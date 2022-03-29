using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class Usuario
    {

        private static string name;
        private static string cpf;
        private static string email;

        public Usuario(string rname, string rcpf, string remail)
        {
            name = rname;
            cpf = rcpf;
            email = remail;
        }

        public static string getName()
        {
            return name;
        }

        public string CPF
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

    }
}