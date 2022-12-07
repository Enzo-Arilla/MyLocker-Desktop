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
        public Apm(int id, string requisitionPDF, int status, string? FK_functionary_cpf, string FK_student_ra, Alunos student)
        {
            Id = id;
            RequisitionPdf = requisitionPDF;
            Status = status;
            FK_Functionary_Cpf = FK_functionary_cpf;
            FK_Student_Ra = FK_student_ra;
            Student = student;
        }


        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("requisitionPDF")]
        public string RequisitionPdf { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("FK_functionary_cpf")]
        public string? FK_Functionary_Cpf { get; set; }

        [JsonProperty("FK_student_ra")]
        public string FK_Student_Ra { get; set; }

        [JsonProperty("student")]
        public Alunos Student { get; set; }
    }
}
