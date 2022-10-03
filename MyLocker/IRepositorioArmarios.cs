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

        [Get("/lockers/{lockerNumberString}")]
        Task<Armario> FindLockerByNumber(String lockerNumberString);

        [Post("/lockers/set-is-rented")]
        Task SetLockerIsRented([Body]SetLockerIsRentedRequest locker);

        [Post("/clear-locker-demonstration")]
        Task EmptyLocker([Body]String ra);

    }
}
