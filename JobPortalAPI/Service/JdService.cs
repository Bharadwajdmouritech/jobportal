using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Service.Interfaces;

namespace JobPortalAPI.Service
{
    public class JdService:IJdService
    {
        private readonly IUnitOfWorkRepository _unitOfWorkRepository;
        public JdService(IUnitOfWorkRepository unitOfWorkRepository)
        {
            _unitOfWorkRepository = unitOfWorkRepository;
        }

        public async Task<List<JobDescription>> GetAllJds()
        {
            var getAllJds = await _unitOfWorkRepository.jdRepo.GetAllJds();
            return getAllJds;
        }

        public async Task<JobDescription> GetJdById(int id)
        {
            var getJd = await _unitOfWorkRepository.jdRepo.GetJdById(id);
            return getJd;
        }

        public async Task<JobDescription> InsertJd(JobDescription jd)
        {
            var addJd = await _unitOfWorkRepository.jdRepo.InsertJd(jd);
            return addJd;
        }

        public async Task<JobDescription> UpdateJd(JobDescription jd)
        {
            var updateJd = await _unitOfWorkRepository.jdRepo.UpdateJd(jd);
            return updateJd;
        }
        public async Task<JobDescription> DeleteJd(JobDescription jd)
        {
            var deleteJd = await _unitOfWorkRepository.jdRepo.DeleteJd(jd);
            return deleteJd;
        }
    }
}