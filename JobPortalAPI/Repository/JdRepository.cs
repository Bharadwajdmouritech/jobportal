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
        public async Task<List<Jd>> GetAllJds()
        {
           var getAllJds = await _jobPortalDbContext.Jds.ToListAsync();
            return getAllJds;
        }

        public async Task<Jd> GetJdById(int id)
        {
            var getJd =  await _jobPortalDbContext.Jds.Where(x=>x.JobDescId == id).FirstOrDefaultAsync();
            return getJd;
        }

        public async Task<Jd> InsertJd(Jd jd)
        {
            var addJd = await _jobPortalDbContext.Jds.AddAsync(jd);
            await _jobPortalDbContext.SaveChangesAsync();
            return addJd.Entity;
        }

        public async Task<Jd> UpdateJd(Jd jd)
        {
            var updateJd = _jobPortalDbContext.Jds.Update(jd);
            await _jobPortalDbContext.SaveChangesAsync();
            return await Task.FromResult(updateJd.Entity);
        }
        public async Task<Jd> DeleteJd(Jd jd)
        {
            var deleteJd = await _jobPortalDbContext.Jds.Where(x=>x.JobDescId.Equals(jd.JobDescId)).FirstOrDefaultAsync();
            if(deleteJd != null)
            {
                var data = _jobPortalDbContext.Jds.Remove(deleteJd);
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