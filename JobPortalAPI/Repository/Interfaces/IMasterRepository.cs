using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;

namespace JobPortalAPI.Repository.Interfaces
{
    public interface IMasterRepository
    {
        Task<List<Admin>> GetAllAdmin();
        Task AddAdmin(Admin admin);
        Task<Admin> GetAdminById(int id);
        Task UpdateAdminById(Admin admin);
        Task DeleteAdminById(int id);
        Task<List<City>> GetAllCity();
        Task<City> GetCityById(int id);
        Task<List<Designation>> GetAllDesignation();
        Task<Designation> GetDesignationById(int id);
        Task<List<JobFunction>> GetAllJobFunction();
        Task<JobFunction> GetJobFunctionById(int id);
    }
}