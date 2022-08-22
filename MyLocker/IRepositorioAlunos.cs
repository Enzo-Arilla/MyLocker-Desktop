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

        [Post("/students")]
        Task CreateAluno([Body] Alunos aluno);

        [Post("/students/update-locker-number")]
        Task SetStudentLockerNumber([Body] SetStudentLockerNumberRequest aluno);
    }
}
