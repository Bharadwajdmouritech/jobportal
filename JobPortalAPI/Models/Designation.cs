
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Models;

public class Designation
{
    [Key]
    public int DesignationId { get; set; }

    public string? Role { get; set; }
    public bool IsActive {get;set;}
    
    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedOn { get; set; }

    [ConcurrencyCheck]
    public byte[]? RowTimeStamp { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual ICollection<Jd> Jds { get; set; } = new List<Jd>();
}
