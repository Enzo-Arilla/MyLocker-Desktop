using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace MyLocker
{
    public interface IRepositorioArmarios
    {
        [Get("/lockers")]
        Task<Armario[]> ListArmarios();
    }
}
