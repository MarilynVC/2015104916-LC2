using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using _2015104916.Entities.Entities;

namespace _2015104916.Persistence.EntitiesConfiguration
{
    public class CinturonConfiguration : EntityTypeConfiguration<Cinturon>
    {
        public CinturonConfiguration()
       {
           //Table Configuration
           ToTable("Cinturones");
           HasKey(c => c.CinturonId);
           //Relationship Configuration
           HasRequired(c => c.Asiento)
               .WithRequiredDependent(c => c.Cinturon);

       }
    }
}
