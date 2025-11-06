using System.Collections.Generic;
using System.Threading.Tasks;

namespace PPA_Semana09.Services
{
    public interface ICarrerasProvider
    {
        Task<IReadOnlyList<string>> ObtenerCarrerasAsync();
    }
}
