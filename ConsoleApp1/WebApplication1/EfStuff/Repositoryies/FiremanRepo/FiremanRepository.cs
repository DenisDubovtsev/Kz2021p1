﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.EfStuff.Model;
using WebApplication1.EfStuff.Model.Firemen;

namespace WebApplication1.EfStuff.Repositoryies.FiremanRepo
{
    public class FiremanRepository : BaseRepository<Fireman>
    {
        public FiremanRepository(KzDbContext kzDbContext):base(kzDbContext)    
        {
        }

        public Fireman GetByName(string name)
        {
            return _kzDbContext.Firemen.SingleOrDefault(x => x.Citizen.Name == name);
        }
    }
}
