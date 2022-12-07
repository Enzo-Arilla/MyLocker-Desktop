using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public interface IRepositorioAlunos
    {
        [Get("/students")]
        Task<Alunos[]> ListAlunos();

        [Get("/students/ra/{ra}")]
        Task<Alunos> FindStudentByRa(string ra);

        [Post("/students")]
        Task CreateAluno([Body]Alunos aluno);

        [Post("/students/update-status")]
        Task ChangeStudentStatus([Body]ChangeStudentStatusRequest changeStudentStatusRequest);

        [Post("/students/update-locker-number")]
        Task SetStudentLockerNumber([Body]SetStudentLockerNumberRequest aluno);

        [Put("/students/update-informations")]
        Task UpdateStudentInformation([Body]Alunos aluno);

    }
}
