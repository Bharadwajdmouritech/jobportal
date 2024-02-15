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
        public async Task<ActionResult<List<Jd>>> GetAllJds()
        {
            var getAllJds = await _unitOfWorkService.jdService.GetAllJds();
            return Ok(getAllJds);
        }
        
        [HttpGet]
        [Route("GetJdById")]
        public async Task<ActionResult<Jd>> GetJdById(int id)
        {
            var getJd = await _unitOfWorkService.jdService.GetJdById(id);
            return Ok(getJd);
        }

        [HttpPost]
        [Route("InsertJd")]
        public async Task<ActionResult<Jd>> InsertJd(Jd jd)
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
        public async Task<ActionResult<Jd>> UpdateJd(Jd jd)
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
        [Route("DeleteJd")]
        public async Task<ActionResult<Jd>> DeleteJd(Jd jd)
        {
            var deleteJd = await _unitOfWorkService.jdService.DeleteJd(jd);
            return Ok(deleteJd);
        }    
    }
}