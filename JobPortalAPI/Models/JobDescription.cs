using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Models;

public class JobDescription
{
     [Key]
    public int JobDescId { get; set; }

    public string? CompanyName { get; set; }

    public int? Experience { get; set; }

    public string? JobTitle { get; set; }

    public string? LinkedinUrl { get; set; }

    public DateTime? JoiningDate { get; set; }

    public string? Description { get; set; }

    public int? AdminId { get; set; }

    public int? CityId { get; set; }

    public int? JobId { get; set; }

    public int? DesignationId { get; set; }

    public DateTime? PostedDate { get; set; }

    public string? MandatorySkills { get; set; }

    public string? OptionalSkills { get; set; }

    public string? Certification { get; set; }

    public DateTime? ExpiryOfRole { get; set; }

    public bool IsActive {get;set;}
    
    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedOn { get; set; }
    
    [Timestamp]
    [ConcurrencyCheck]
    public byte[] RowTimeStamp { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual City? City { get; set; }

    public virtual Designation? Designation { get; set; }

    public virtual Roles? Roles { get; set; }
}
