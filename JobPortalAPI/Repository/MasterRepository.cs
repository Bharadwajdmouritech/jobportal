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
        public async Task<JobsByFunction> GetJobsByFunctionName(string name)
        {
            JobsByFunction jbf = new JobsByFunction();
            var data = await _context.Functions.FirstOrDefaultAsync(f => f.IsActive && f.FunctionName == name);
            if (data != null)
            {
                jbf.FunctionName = data.FunctionName;
                jbf.Count = await _context.Fu_Jo_Ros.Where(fjr => fjr.FunctionId == data.FunctionId && fjr.IsActive).CountAsync();
                List<int> job = await _context.Fu_Jo_Ros.Where(fjr => fjr.FunctionId == data.FunctionId && fjr.IsActive).Select(j => j.JobId).ToListAsync();
                foreach (var j in job)
                {
                    Job jobName = await _context.Jobs.FirstOrDefaultAsync(jb => jb.JobId == j);
                    jbf.JobNames.Add(jobName.JobTitle);
                }
                return jbf;
            }
            else
            {
                return jbf;
            }
        }
    }
}