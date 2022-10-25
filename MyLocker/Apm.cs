using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class Apm
    {
        [JsonConstructor]
        public Apm(int id, String requisitionPDF, int status, String? FK_functionary_cpf, Alunos? student) 
        {
            Id = id;
            RequisitionPdf = requisitionPDF;
            Status = status;
            FK_Functionary_Cpf = FK_functionary_cpf;
            Student = student;
        }


        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("requisitionPDF")]
        public String RequisitionPdf { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("FK_functionary_cpf")]
        public String? FK_Functionary_Cpf { get; set; }

        [JsonProperty("student")]
        public Alunos? Student { get; set; }
    }
}
