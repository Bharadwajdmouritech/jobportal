using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;
using JobPortalAPI.SP_Models;

namespace JobPortalAPI.Repository.Interfaces
{
    public interface IMasterRepository
    {
        Task<List<City>> GetAllCities();
        Task<City> GetCityById(int id);
        Task<List<Designation>> GetAllDesignations();
        Task<Designation> GetDesignationById(int id);
        Task<List<Roles>> GetAllJobFunctions();
        Task<Roles> GetJobFunctionById(int id);
        Task<List<JobTitleWithFunctionClass>> GetSPJobTitleWithFunction();
    }
}