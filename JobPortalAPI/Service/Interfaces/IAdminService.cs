using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;

namespace JobPortalAPI.Service.Interfaces
{
    public interface IAdminService
    {
        Task<List<Admin>> GetAllAdmins();
        Task<Admin> GetAdminById(int id);
        Task<Admin> InsertAdmin(Admin Admin);
        Task<Admin> UpdateAdmin(Admin Admin);
        Task<Admin> DeleteAdmin(Admin Admin); 
    }
}