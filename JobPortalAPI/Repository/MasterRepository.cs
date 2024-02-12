using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Models;
using JobPortalAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace JobPortalAPI.Repository
{
    public class MasterRepository : IMasterRepository
    {
        private JobPortalDbContext _context;

        public MasterRepository(JobPortalDbContext context)
        {
            _context=context;
        }

        public async Task<List<Admin>> GetAllAdmin()
        {
            return await _context.Admins.ToListAsync();
        }

        public async Task AddAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync(); 
        }

        public async Task<Admin> GetAdminById(int id)
        {
            return await _context.Admins.FirstOrDefaultAsync(a => a.AdminId == id);
        }

        public async Task UpdateAdminById(Admin admin)
        {
            var existingAdmin = await _context.Admins.FindAsync(admin.AdminId);

            if(existingAdmin != null){
                existingAdmin.AdminName = admin.AdminName;
                existingAdmin.CompanyName = admin.CompanyName;
                existingAdmin.EmailId = admin.EmailId;
                existingAdmin.LinkedinUrl = admin.LinkedinUrl;
                existingAdmin.JoiningDate = admin.JoiningDate;
                existingAdmin.DesignationId = admin.DesignationId;
                existingAdmin.CityId=admin.CityId;

                await _context.SaveChangesAsync();
            }
             
        }

        public async Task DeleteAdminById(int id){
            var adminToDelete = await _context.Admins.FindAsync(id);
            if(adminToDelete!=null){
                _context.Admins.Remove(adminToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<City>> GetAllCity(){
            return await _context.Cities.ToListAsync();
        }
        public async Task<City> GetCityById(int id){
            return await _context.Cities.FirstOrDefaultAsync(a => a.CityId == id);
        }
        public async Task<List<Designation>> GetAllDesignation(){
            return await _context.Designations.ToListAsync();
        }
        public async Task<Designation> GetDesignationById(int id){
            return await _context.Designations.FirstOrDefaultAsync(a => a.DesignationId == id);
        }
        public async Task<List<JobFunction>> GetAllJobFunction(){
            return await _context.JobFunctions.ToListAsync();
        }
        public async Task<JobFunction> GetJobFunctionById(int id){
            return await _context.JobFunctions.FirstOrDefaultAsync(a => a.JobId == id);
        }
    }
}