using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Models;

public class Admin
{
     [Key]
    public int AdminId { get; set; }

    public string? AdminName { get; set; }

    public string? CompanyName { get; set; }

    public string? EmailId { get; set; }

    public string? LinkedinUrl { get; set; }

    public DateTime JoiningDate{get;set;}

    public bool IsActive {get;set;}

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedOn { get; set; }

    [Timestamp]
    [ConcurrencyCheck]
    public byte[] RowTimeStamp { get; set; }
    
    public int? CityId { get; set; }
    public virtual City? City { get; set; }
    
    public int? DesignationId { get; set; }
    public virtual Designation? Designation { get; set; }

    public virtual ICollection<Jd> Jds { get; set; } = new List<Jd>();
}
