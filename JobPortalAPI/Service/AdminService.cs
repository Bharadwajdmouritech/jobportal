using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Service.Interfaces;

namespace JobPortalAPI.Service
{
    public class AdminService:IAdminService
    {
        private readonly IUnitOfWorkRepository _unitOfWorkRepository;
        public AdminService(IUnitOfWorkRepository unitOfWorkRepository)
        {
            _unitOfWorkRepository = unitOfWorkRepository;
        }

        public async Task<List<Admin>> GetAllAdmins()
        {
            var getAllAdmins = await _unitOfWorkRepository.adminRepository.GetAllAdmins();
            return getAllAdmins;
        }

        public async Task<Admin> GetAdminById(int id)
        {
            var getAdmin = await _unitOfWorkRepository.adminRepository.GetAdminById(id);
            return getAdmin;
        }

        public async Task<Admin> InsertAdmin(Admin admin)
        {
            var addAdmin = await _unitOfWorkRepository.adminRepository.InsertAdmin(admin);
            return addAdmin;
        }

        public async Task<Admin> UpdateAdmin(Admin admin)
        {
            var updateAdmin = await _unitOfWorkRepository.adminRepository.UpdateAdmin(admin);
            return updateAdmin;
        }
        public async Task<Admin> DeleteAdmin(Admin admin)
        {
            var deleteAdmin = await _unitOfWorkRepository.adminRepository.DeleteAdmin(admin);
            return deleteAdmin;
        }
    }
}