using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Models;
using JobPortalAPI.Repository;
using JobPortalAPI.Service.Interfaces;

namespace JobPortalAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController: ControllerBase
    {
        private readonly IUnitOfWorkService _unitOfWorkService;
        public AdminController(IUnitOfWorkService unitOfWorkService)
        {
            _unitOfWorkService = unitOfWorkService;
        }
        [HttpGet]
        [Route("GetAllAdmins")]
        public async Task<ActionResult<List<Admin>>> GetAllAdmins()
        {
            var getAllAdmins = await _unitOfWorkService.adminService.GetAllAdmins();
            return Ok(getAllAdmins);
        }
        
        [HttpGet]
        [Route("GetAdminById")]
        public async Task<ActionResult<Admin>> GetAdminById(int id)
        {
            var getAdmin = await _unitOfWorkService.adminService.GetAdminById(id);
            return Ok(getAdmin);
        }

        [HttpPost]
        [Route("InsertAdmin")]
        public async Task<ActionResult<Admin>> InsertAdmin(Admin admin)
        {
            if(ModelState.IsValid)
            {
                var addAdmin = await _unitOfWorkService.adminService.InsertAdmin(admin);
                return Ok(addAdmin);
            }
            else
            {
                return Ok();
            }
        }

        [HttpPut]
        [Route("UpdateAdmin")]
        public async Task<ActionResult<Admin>> UpdateAdmin(Admin admin)
        {
            if(ModelState.IsValid)
            {
                var updateAdmin = await _unitOfWorkService.adminService.UpdateAdmin(admin);
                return Ok(updateAdmin);
            }
            else
            {
                return Ok();
            }
        }

        [HttpDelete]
        [Route("DeleteAdmin")]
        public async Task<ActionResult<Admin>> DeleteAdmin(Admin admin)
        {
            var deleteAdmin = await _unitOfWorkService.adminService.DeleteAdmin(admin);
            return Ok(deleteAdmin);
        }      
    }
}