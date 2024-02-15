using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;

namespace JobPortalAPI.Repository.Interfaces
{
    public interface IJdRepository
    {
        Task<List<Jd>> GetAllJds();
        Task<Jd> GetJdById(int id);
        Task<Jd> InsertJd(Jd jd);
        Task<Jd> UpdateJd(Jd jd);
        Task<Jd> DeleteJd(Jd jd);
    }
}