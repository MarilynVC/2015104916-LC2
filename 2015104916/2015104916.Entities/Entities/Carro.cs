using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015104916.Entities.Entities
{
    public class Carro
    {

         public int CarroId { set; get; }
         public string NumSerieMotor { set; get; }
         public string NumSerieChasis { set; get; }
         public int EnsambladoraId { set; get; }
         public List<Llanta> Llantas { set; get; }
         public List<Asiento> Asientos { set; get; }

         public TipoCarro TipoCarro { set; get; }
         public TipoBus TipoBus { set; get; }
         public TipoAuto TipoAuto { set; get; }

         public int PropietarioId { set; get; }
         public Propietario Propietario { set; get; }
         public Parabrisas Parabrisas { set; get; }
         public Volante Volante { set; get; }
         public Ensambladora Ensambladora { set; get; }
              
    }
}
