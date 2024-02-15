using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Models;
using JobPortalAPI.Data;
using Microsoft.EntityFrameworkCore;
using JobPortalAPI.SP_Models;
using Dapper;

namespace JobPortalAPI.Repository
{
    public class MasterRepository : IMasterRepository
    {
        private JobPortalDbContext _context;
        public MasterRepository(JobPortalDbContext context)
        {
            _context = context;
        }
        public async Task<List<City>> GetAllCities()
        {
            return await _context.Cities.ToListAsync();
        }
        public async Task<City> GetCityById(int id)
        {
            return await _context.Cities.FirstOrDefaultAsync(a => a.CityId == id);
        }
        public async Task<List<Designation>> GetAllDesignations()
        {
            return await _context.Designations.ToListAsync();
        }
        public async Task<Designation> GetDesignationById(int id)
        {
            return await _context.Designations.FirstOrDefaultAsync(a => a.DesignationId == id);
        }
        public async Task<List<JobFunction>> GetAllJobFunctions()
        {
            return await _context.JobFunctions.ToListAsync();
        }
        public async Task<JobFunction> GetJobFunctionById(int id)
        {
            return await _context.JobFunctions.FirstOrDefaultAsync(a => a.JobId == id);
        }
        public async Task<List<JobTitleWithFunctionClass>> GetSPJobTitleWithFunction()
        {
            var conn = _context.Database.GetDbConnection();
            var userTasks = await conn.QueryAsync<JobTitleWithFunctionClass>("EXEC [dbo].[SP_JobTitleWithFunction]");
            return userTasks.ToList();
        }
    }
}