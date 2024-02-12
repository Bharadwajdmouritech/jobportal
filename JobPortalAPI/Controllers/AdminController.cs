using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Models;
using JobPortalAPI.Service.Interfaces;

namespace JobPortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
           private IUnitOfWorkService _unitOfWork;

           public AdminController(IUnitOfWorkService unitOfWork)
           {
                _unitOfWork = unitOfWork;
           }

           [HttpGet("GetAllAdmin")]
           public async Task<IActionResult> GetAllAdmin()
           {
            var allAdmins = await _unitOfWork.masterService.GetAllAdmin();
            return Ok(allAdmins);
           }

           [HttpPost("AddAdmin/admin")]
           public async Task<IActionResult> AddAdmin(Admin admin)
           {
            await _unitOfWork.masterService.AddAdmin(admin);
            return Ok("Admin added successfully!");
           }

           [HttpGet("GetAdminById/id")]
           public async Task<IActionResult> GetAdminById(int id)
           {
            var admin = await _unitOfWork.masterService.GetAdminById(id);
            return Ok(admin);
           }

           [HttpPost("UpdateAdminById/admin")]
           public async Task<IActionResult> UpdateAdminById(Admin admin)
           {
            await _unitOfWork.masterService.UpdateAdminById(admin);
            return Ok("Updated successfully!");
           }

            [HttpDelete("DeleteAdminById/id")]
            public async Task<IActionResult> DeleteAdminById(int id)
            {
             await _unitOfWork.masterService.DeleteAdminById(id);
             return Ok("Deleted successfully!");
            }
    }
}