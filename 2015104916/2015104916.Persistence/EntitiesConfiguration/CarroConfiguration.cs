using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using _2015104916.Entities.Entities;

namespace _2015104916.Persistence.EntitiesConfiguration
{
    public class CarroConfiguration : EntityTypeConfiguration<Carro>
    {
        public CarroConfiguration()
       {
           //Table Configuration
           ToTable("Carros");
           HasKey(c => c.CarroId);
           //Relationship Configuration
           HasRequired(c => c.Ensambladora)
                .WithMany(c=>c.Carros);
           HasRequired(c => c.Propietario)
                .WithRequiredDependent(c => c.Carro);

       }
    }
}
