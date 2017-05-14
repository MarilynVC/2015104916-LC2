using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using _2015104916.Entities.Entities;

namespace _2015104916.Persistence.EntitiesConfiguration
{
    public class AsientoConfiguration : EntityTypeConfiguration<Asiento>
    {
        public AsientoConfiguration()
       {
           //Table Configuration
           ToTable("Asientos");
           HasKey(c => c.AsientoId);
           //Relationship Configuration
           HasRequired(c => c.Carro)
                .WithMany(c => c.Asientos);

       }
    }
}
