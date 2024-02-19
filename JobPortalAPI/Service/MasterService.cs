using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Service.Interfaces;
using JobPortalAPI.SP_Models;

namespace JobPortalAPI.Service
{
    public class MasterService:IMasterService
    {
        private readonly IUnitOfWorkRepository  _unitOfWorkRepository;
        public  MasterService(IUnitOfWorkRepository unitOfWorkRepository)
        {
            _unitOfWorkRepository = unitOfWorkRepository;
        }
        public async Task<List<City>> GetAllCities()
        {
            return await _unitOfWorkRepository.masterRepo.GetAllCities();
        }
        public async Task<City> GetCityById(int id)
        {
            return await _unitOfWorkRepository.masterRepo.GetCityById(id);
        }
        public async Task<List<Designation>> GetAllDesignations()
        {
            return await _unitOfWorkRepository.masterRepo.GetAllDesignations();
        }
        public async Task<Designation> GetDesignationById(int id)
        {
            return await _unitOfWorkRepository.masterRepo.GetDesignationById(id);
        }
        public async Task<List<Roles>> GetAllJobFunctions()
        {
            return await _unitOfWorkRepository.masterRepo.GetAllJobFunctions();
        }
        public async Task<Roles> GetJobFunctionById(int id)
        {
            return await _unitOfWorkRepository.masterRepo.GetJobFunctionById(id);
        }
        public async Task<List<JobTitleWithFunctionClass>> GetSPJobTitleWithFunction()
        {
            return await _unitOfWorkRepository.masterRepo.GetSPJobTitleWithFunction();
        }
    }
}