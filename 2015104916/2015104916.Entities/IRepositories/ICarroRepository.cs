using _2015104916.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015104916.Entities.IRepositories
{
    public interface ICarroRepository
    {

        IEnumerable<Carro> GetCarroByTipoCarro(TipoCarro tipoCarro);
        IEnumerable<Carro> GetCarroByTipoAuto(TipoAuto tipoAuto);
        IEnumerable<Carro> GetCarroByTipoBus(TipoBus tipoBus);
        IEnumerable<Carro> GetCarroByPropietario(Propietario propietario);
        IEnumerable<Carro> GetCarroByEnsambladora(Ensambladora ensambladora);
    }
}
