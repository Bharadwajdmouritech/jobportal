using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;
using JobPortalAPI.Service.Interfaces;
using JobPortalAPI.SP_Models;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterController : ControllerBase
    {
        private readonly IUnitOfWorkService _unitOfWorkService;
        public MasterController(IUnitOfWorkService unitOfWorkService)
        {
            _unitOfWorkService = unitOfWorkService;
        }
        
        [HttpGet]
        [Route("GetAllCities")]
        public async Task<ActionResult<List<City>>> GetAllCities()
        {
            var getAllAdmins = await _unitOfWorkService.masterService.GetAllCities();
            return Ok(getAllAdmins);
        }
        
        [HttpGet]
        [Route("GetCityById")]
        public async Task<ActionResult<City>> GetCityById(int id)
        {
            var getAdmin = await _unitOfWorkService.masterService.GetCityById(id);
            return Ok(getAdmin);
        }
        [HttpGet]
        [Route("GetAllDesignations")]
        public async Task<ActionResult<List<Designation>>> GetAllDesignations()
        {
            var getAllAdmins = await _unitOfWorkService.masterService.GetAllDesignations();
            return Ok(getAllAdmins);
        }
        
        [HttpGet]
        [Route("GetDesignationById")]
        public async Task<ActionResult<Designation>> GetDesignationById(int id)
        {
            var getAdmin = await _unitOfWorkService.masterService.GetDesignationById(id);
            return Ok(getAdmin);
        }
        [HttpGet]
        [Route("GetAllJobFunctions")]
        public async Task<ActionResult<List<JobFunction>>> GetAllJobFunctions()
        {
            var getAllAdmins = await _unitOfWorkService.masterService.GetAllJobFunctions();
            return Ok(getAllAdmins);
        }
        
        [HttpGet]
        [Route("GetJobFunctionById")]
        public async Task<ActionResult<JobFunction>> GetJobFunctionById(int id)
        {
            var getAdmin = await _unitOfWorkService.masterService.GetJobFunctionById(id);
            return Ok(getAdmin);
        }

        [HttpGet]
        [Route("GetSPJobTitleWithFunction")]
        public async Task<List<JobTitleWithFunctionClass>> GetSPJobTitleWithFunction()
        {
            var getSPJobTitleWithFunction = await _unitOfWorkService.masterService.GetSPJobTitleWithFunction();
            return getSPJobTitleWithFunction;
        }
    }
}