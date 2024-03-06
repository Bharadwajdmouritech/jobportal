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
        public async Task<List<Roles>> GetAllJobFunctions()
        {
            return await _context.Roles.ToListAsync();
        }
        public async Task<Roles> GetJobFunctionById(int id)
        {
            return await _context.Roles.FirstOrDefaultAsync(a => a.RoleId == id);
        }

        public async Task<JobsByFunction> GetJobsByFunctionName(string name)
        {
            JobsByFunction jobsByFunction = new JobsByFunction();
            if(name != null)
            {
                var functions = await _context.Functions.FirstOrDefaultAsync(f=>f.FunctionName.Equals(name));
                if(functions != null)
                {
                    var job = await _context.Jobs.Where(j=>j.FunctionId == functions.FunctionId).ToListAsync();
                    jobsByFunction.FunctionName = functions.FunctionName;
                    jobsByFunction.Count = job.Count();
                    jobsByFunction.Jobs = job;
                    return jobsByFunction;
                }
                else
                {
                    return jobsByFunction;
                }
            }
            else
            {
                return jobsByFunction;
            }
        }

        // public async Task<List<JobTitleWithFunctionClass>> GetSPJobTitleWithFunction()
        // {
        //     var conn = _context.Database.GetDbConnection();
        //     var userTasks = await conn.QueryAsync<JobTitleWithFunctionClass>("EXEC [dbo].[SP_JobTitleWithFunction]");
        //     return userTasks.ToList();
        // }
    }
}