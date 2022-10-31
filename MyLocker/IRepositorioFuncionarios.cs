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

        [Post("/functionaries")]
        Task<Funcionario> CreateFuncionario([Body]Funcionario funcionario);

        [Put("/functionaries/update-password")]
        Task UpdatePassword([Body]UpdateFunctionaryPasswordRequest senhaFuncionario);

        [Put("/functionaries/generate-code")]
        Task<GenerateFunctionaryVerificationCodeResponse> GenerateFunctionaryVerificationCode([Body]GenerateFunctionaryVerificationCodeRequest generateFunctionaryVerificationCodeRequest);

    }
}
