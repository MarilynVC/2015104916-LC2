﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015104916.Entities.Entities
{
    public class Propietario
    {
        public int PropietarioId { set; get; }
        public string Dni{set;get;}
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public string Licencia { set; get; }
        public int CarroId { set; get; }
        public Carro Carro { set; get; }
             
       

       
    }
}
