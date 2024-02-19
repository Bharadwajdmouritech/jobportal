using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Data;
using JobPortalAPI.Models;
using JobPortalAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JobPortalAPI.Repository
{
    public class JdRepository:IJdRepository
    {
        private readonly JobPortalDbContext _jobPortalDbContext;

        public JdRepository(JobPortalDbContext jobPortalDbContext)
        {
            _jobPortalDbContext = jobPortalDbContext;
        }
        public async Task<List<JobDescription>> GetAllJds()
        {
           var getAllJds = await _jobPortalDbContext.JobDescriptions.ToListAsync();
            return getAllJds;
        }

        public async Task<JobDescription> GetJdById(int id)
        {
            var getJd =  await _jobPortalDbContext.JobDescriptions.Where(x=>x.JobDescId == id).FirstOrDefaultAsync();
            return getJd;
        }

        public async Task<JobDescription> InsertJd(JobDescription jd)
        {
            var addJd = await _jobPortalDbContext.JobDescriptions.AddAsync(jd);
            await _jobPortalDbContext.SaveChangesAsync();
            return addJd.Entity;
        }

        public async Task<JobDescription> UpdateJd(JobDescription jd)
        {
            var updateJd = _jobPortalDbContext.JobDescriptions.Update(jd);
            await _jobPortalDbContext.SaveChangesAsync();
            return await Task.FromResult(updateJd.Entity);
        }
        public async Task<JobDescription> DeleteJd(JobDescription jd)
        {
            var deleteJd = await _jobPortalDbContext.JobDescriptions.Where(x=>x.JobDescId.Equals(jd.JobDescId)).FirstOrDefaultAsync();
            if(deleteJd != null)
            {
                var data = _jobPortalDbContext.JobDescriptions.Remove(deleteJd);
                await _jobPortalDbContext.SaveChangesAsync();
                return deleteJd;
            }
            else
            {
                return null;
            }
        }

    }
}