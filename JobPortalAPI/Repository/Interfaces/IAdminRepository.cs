using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;

namespace JobPortalAPI.Repository.Interfaces
{
    public interface IAdminRepository
    {
        Task<List<Admin>> GetAllAdmins();
        Task<Admin> GetAdminById(int id);
        Task<Admin> InsertAdmin(Admin admin);
        Task<Admin> UpdateAdmin(Admin admin);
        Task<Admin> DeleteAdmin(Admin admin);
    }
}