using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Data;

namespace JobPortalAPI.Repository
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        public IMasterRepository masterRepo {get;set;}

        private JobPortalDbContext _context;

        public UnitOfWorkRepository(JobPortalDbContext context)
        {
            _context = context;
            masterRepo = new MasterRepository(_context);
        }
    }
}