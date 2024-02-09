using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Models;

namespace JobPortalAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
           private IUnitofWorkRepository _unitOfWork;

           public AdminController(IUnitofWorkRepository unitOfWork){
                _unitOfWork=unitOfWork;
           }

           [HttpGet("GetAllAdmin")]
           public IActionResult GetAllAdmin(){
            var allAdmins = _unitOfWork.masterRepo.GetAllAdmin();
            return Ok(allAdmins);
           }

           [HttpPost("AddAdmin/admin")]
           public IActionResult AddAdmin(Admin admin){
            var addAdmin = _unitOfWork.masterRepo.AddAdmin(admin);
            return Ok(addAdmin);
           }

           [HttpGet("GetAdminById/id")]
           public IActionResult GetAdminById(int id){
            var admin = _unitOfWork.masterRepo.GetAdminById(id);
            return Ok(admin);
           }

           [HttpPost("UpdateAdminById/admin")]
           public IActionResult UpdateAdminById(Admin admin){
            var updateAdmin = _unitOfWork.masterRepo.UpdateAdminById(admin);
            return Ok(updateAdmin);
           }

            [HttpDelete("DeleteAdminById/id")]
            public IActionResult UpdateAdminById(int id){
             var deleteAdmin = _unitOfWork.masterRepo.DeleteAdminById(id);
             return Ok(deleteAdmin);
            }
           

    }
}