using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace MyLocker
{
    public interface IRepositorioFuncionarios
    {
        [Get("/functionaries/{cpf}")]
        Task<Funcionario> ReturnFuncionario(string cpf);

        [Get("/functionaries/{cpf}/verify-code/{typedCode}")]
        Task VerifyFunctionaryCode(string cpf, string typedCode);

        [Post("/functionaries")]
        Task CreateFuncionario([Body]Funcionario funcionario);

        [Put("/functionaries/update-password")]
        Task UpdatePassword([Body]UpdateFunctionaryPasswordRequest senhaFuncionario);

        [Put("/functionaries/generate-code")]
        Task GenerateFunctionaryVerificationCode([Body]GenerateFunctionaryVerificationCodeRequest generateFunctionaryVerificationCodeRequest);   
    }
}
