using System.Collections.Generic;
using System.Threading.Tasks;

namespace PPA_Semana09.Services
{
    public class CarrerasProviderMock : ICarrerasProvider
    {
        public Task<IReadOnlyList<string>> ObtenerCarrerasAsync() =>
            Task.FromResult<IReadOnlyList<string>>(new List<string>
            {
                "Ing en Desarrollo de software",
                "Ing Industrial",
                "Sociologia",
                "Ing Ambiental",
                "Ing en Telematica"
            });
    }
}
