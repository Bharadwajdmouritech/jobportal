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

        public async Task<List<Jd>> GetAllJds()
        {
            var getAllJds = await _unitOfWorkRepository.jdRepo.GetAllJds();
            return getAllJds;
        }

        public async Task<Jd> GetJdById(int id)
        {
            var getJd = await _unitOfWorkRepository.jdRepo.GetJdById(id);
            return getJd;
        }

        public async Task<Jd> InsertJd(Jd jd)
        {
            var addJd = await _unitOfWorkRepository.jdRepo.InsertJd(jd);
            return addJd;
        }

        public async Task<Jd> UpdateJd(Jd jd)
        {
            var updateJd = await _unitOfWorkRepository.jdRepo.UpdateJd(jd);
            return updateJd;
        }
        public async Task<Jd> DeleteJd(Jd jd)
        {
            var deleteJd = await _unitOfWorkRepository.jdRepo.DeleteJd(jd);
            return deleteJd;
        }
    }
}