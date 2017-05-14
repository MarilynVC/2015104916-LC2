using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015104916.Entities.Entities
{
    public class Cinturon
    {
        public int CinturonId { set; get; }
        public string NumSerie { set; get; }
        public int Metraje { set; get; }

        public int AsientoId { set; get; }
        public Asiento Asiento { set; get; }
    }
}
