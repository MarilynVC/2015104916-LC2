﻿using _2015104916.Entities.Entities;
using _2015104916.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015104916.Persistence.Repositories
{
    public class VolanteRepository : Repository<Volante>, IVolanteRepository
    {
        public VolanteRepository(_2015104916DbContext context) : base(context)
        {

        }
    }
}
