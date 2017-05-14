using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015104916.Entities.Entities
{
    public class Llanta
    {
        public int LlantaId { set; get; }
        public string NumSerie { set; get; }
        public int CarroId { set; get; }
        public Carro Carro { set; get; }

    }
}
