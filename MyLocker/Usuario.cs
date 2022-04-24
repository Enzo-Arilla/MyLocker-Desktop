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
        private static string lastName;
        private static string cpf;
        private static string email;
        private static int status;

        public Usuario(string rname, string rlastname, string rcpf, string remail, int rstatus)
        {
            name = rname;
            lastName = rlastname;
            cpf = rcpf;
            email = remail;
            status = rstatus;
        }

        public static string getName()
        {
            return name + " " + lastName;
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

        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

    }
}