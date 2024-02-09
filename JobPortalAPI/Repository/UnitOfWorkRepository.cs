using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Data;

namespace JobPortalAPI.Repository
{
    public class UnitofWorkRepository : IUnitofWorkRepository
    {
        public IMasterRepository masterRepo {get;set;}

        private JobPortalDbContext _context;

        public UnitofWorkRepository(JobPortalDbContext context){
            _context = context;
            masterRepo = new MasterRepository(_context);
        }
    }
}