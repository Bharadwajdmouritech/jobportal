using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Data;
using JobPortalAPI.Models;
using JobPortalAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JobPortalAPI.Repository
{
    public class AdminRepository:IAdminRepository
    {
        private readonly JobPortalDbContext _jobPortalDbContext;

        public AdminRepository(JobPortalDbContext jobPortalDbContext)
        {
            _jobPortalDbContext = jobPortalDbContext;
        }
       
        public async Task<List<Admin>> GetAllAdmins()
        {
            var getAllAdmins = await _jobPortalDbContext.Admins.ToListAsync();
            return getAllAdmins;
        }

        public async Task<Admin> GetAdminById(int id)
        {
            var getAdmin =  await _jobPortalDbContext.Admins.Where(x=>x.AdminId == id).FirstOrDefaultAsync();
            return getAdmin;
        }

        public async Task<Admin> InsertAdmin(Admin admin)
        {
            var addAdmin = await _jobPortalDbContext.Admins.AddAsync(admin);
            await _jobPortalDbContext.SaveChangesAsync();
            return addAdmin.Entity;
        }

        public async Task<Admin> UpdateAdmin(Admin admin)
        {
             var updateAdmin = _jobPortalDbContext.Admins.Update(admin);
             await _jobPortalDbContext.SaveChangesAsync();
            return await Task.FromResult(updateAdmin.Entity);
        }
        public async Task<Admin> DeleteAdmin(Admin admin)
        {
            var deleteAdmin = await _jobPortalDbContext.Admins.Where(x=>x.AdminId.Equals(admin.AdminId)).FirstOrDefaultAsync();
            if(deleteAdmin != null)
            {
                var data = _jobPortalDbContext.Admins.Remove(deleteAdmin);
                await _jobPortalDbContext.SaveChangesAsync();
                return deleteAdmin;
            }
            else
            {
                return null;
            }
        } 
    }
}