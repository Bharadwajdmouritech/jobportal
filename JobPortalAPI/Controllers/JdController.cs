using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;
using JobPortalAPI.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class JdController : ControllerBase
    {
        private readonly IUnitOfWorkService _unitOfWorkService;
        public JdController(IUnitOfWorkService unitOfWorkService)
        {
            _unitOfWorkService = unitOfWorkService;
        }
        [HttpGet]
        [Route("GetAllJds")]
        public async Task<ActionResult<List<JobDescription>>> GetAllJds()
        {
            var getAllJds = await _unitOfWorkService.jdService.GetAllJds();
            return Ok(getAllJds);
        }
        
        [HttpGet]
        [Route("GetJdById")]
        public async Task<ActionResult<JobDescription>> GetJdById(int id)
        {
            var getJd = await _unitOfWorkService.jdService.GetJdById(id);
            return Ok(getJd);
        }

        [HttpPost]
        [Route("AddJd")]
        public async Task<ActionResult<JobDescription>> AddJd(JobDescription jd)
        {
            if(ModelState.IsValid)
            {
                var addJd = await _unitOfWorkService.jdService.InsertJd(jd);
                return Ok(addJd);
            }
            else
            {
                return Ok();
            }
        }

        [HttpPut]
        [Route("UpdateJd")]
        public async Task<ActionResult<JobDescription>> UpdateJd(JobDescription jd)
        {
            if(ModelState.IsValid)
            {
                var updateJd = await _unitOfWorkService.jdService.UpdateJd(jd);
                return Ok(updateJd);
            }
            else
            {
                return Ok();
            }
        }

        [HttpDelete]
        [Route("DeleteJdById")]
        public async Task<ActionResult> DeleteJdById(int id)
        {
            await _unitOfWorkService.jdService.DeleteJd(id);
            return Ok("Deleted Successfully");
        }    
    }
}