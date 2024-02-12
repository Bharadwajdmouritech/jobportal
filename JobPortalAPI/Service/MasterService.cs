using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Service.Interfaces;

namespace JobPortalAPI.Service
{
    public class MasterService:IMasterService
    {
        private readonly IUnitOfWorkRepository  _unitOfWorkRepository;
        public  MasterService(IUnitOfWorkRepository unitOfWorkRepository)
        {
            _unitOfWorkRepository = unitOfWorkRepository;
        }
        public async Task<List<Admin>> GetAllAdmin()
        {
            return await _unitOfWorkRepository.masterRepo.GetAllAdmin();
        }

        public async Task AddAdmin(Admin admin)
        {
            await _unitOfWorkRepository.masterRepo.AddAdmin(admin);
        }

        public async Task<Admin> GetAdminById(int id)
        {
            return await _unitOfWorkRepository.masterRepo.GetAdminById(id);
        }

        public async Task UpdateAdminById(Admin admin)
        {
            await _unitOfWorkRepository.masterRepo.UpdateAdminById(admin);
        }

        public async Task DeleteAdminById(int id)
        {
            await _unitOfWorkRepository.masterRepo.DeleteAdminById(id);
        }
        public async Task<List<City>> GetAllCity()
        {
            return await _unitOfWorkRepository.masterRepo.GetAllCity();
        }
        public async Task<City> GetCityById(int id)
        {
            return await _unitOfWorkRepository.masterRepo.GetCityById(id);
        }
        public async Task<List<Designation>> GetAllDesignation()
        {
            return await _unitOfWorkRepository.masterRepo.GetAllDesignation();
        }
        public async Task<Designation> GetDesignationById(int id)
        {
            return await _unitOfWorkRepository.masterRepo.GetDesignationById(id);
        }
        public async Task<List<JobFunction>> GetAllJobFunction()
        {
            return await _unitOfWorkRepository.masterRepo.GetAllJobFunction();
        }
        public async Task<JobFunction> GetJobFunctionById(int id)
        {
            return await _unitOfWorkRepository.masterRepo.GetJobFunctionById(id);
        }


    }
}