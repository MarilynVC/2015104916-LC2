using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015104916.Entities.IRepositories
{
    public interface IUnityofWork : IDisposable
    {

        IAsientoRepository Asiento { get; }
        ICarroRepository Carro { get; }
        ICinturonRepository Cinturon { get; }
        IEnsambladoraRepository Ensambladora { get; }
        ILlantaRepository Llanta { get; }
        IParabrisasRepository Parabrisas { get; }
        IPropietarioRepository Propietario { get; }
        IVolanteRepository Volante { get; }
        int SaveChanges();
    }
}
