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
        private JobPortalDbContext _context;
        public IMasterRepository masterRepo {get; private set;}
        public IAdminRepository adminRepository {get; private set;}
        public IEmployeeRepository employeeRepository{get;private set;}
        public UnitOfWorkRepository(JobPortalDbContext context)
        {
            _context = context;
            masterRepo = new MasterRepository(_context);
            adminRepository=new AdminRepository(_context);
            employeeRepository = new EmployeeRepository(_context);
        }
    }
}