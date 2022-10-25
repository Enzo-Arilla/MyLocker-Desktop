using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public interface IRepositorioAPM
    {
        [Get("/apms/{id}")]
        Task<Apm> findApmById(String id);

        [Get("/apms")]
        Task<Apm[]> listApms();
    }
}