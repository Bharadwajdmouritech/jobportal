using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Models;

public class Roles
{
     [Key]
    public int RoleId { get; set; }

    public string? Role { get; set; }
    public bool IsActive {get;set;}
    
    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedOn { get; set; }

    [Timestamp]
    [ConcurrencyCheck]
    public byte[] RowTimeStamp { get; set; }
    public virtual ICollection<Designation> Designations {get;set;}=new List<Designation>();
    public virtual ICollection<JobDescription> JobDescriptions { get; set; } = new List<JobDescription>();
}
