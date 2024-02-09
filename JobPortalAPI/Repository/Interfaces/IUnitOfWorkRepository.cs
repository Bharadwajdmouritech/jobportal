using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalAPI.Repository.Interfaces
{
    public interface IUnitofWorkRepository
    {
        IMasterRepository masterRepo {get;}
    }
}