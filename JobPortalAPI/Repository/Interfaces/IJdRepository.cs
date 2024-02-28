using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;

namespace JobPortalAPI.Repository.Interfaces
{
    public interface IJdRepository
    {
        Task<List<JobDescription>> GetAllJds();
        Task<JobDescription> GetJdById(int id);
        Task<JobDescription> InsertJd(JobDescription jd);
        Task<JobDescription> UpdateJd(JobDescription jd);
        Task DeleteJd(int id);
    }
}