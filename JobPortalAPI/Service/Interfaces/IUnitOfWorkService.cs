using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalAPI.Service.Interfaces
{
    public interface IUnitOfWorkService
    {
        IMasterService masterService {get;}
        IJdService jdService {get;}
        IAdminService adminService {get;}
        IEmployeeService employeeService{get;}
    }
}