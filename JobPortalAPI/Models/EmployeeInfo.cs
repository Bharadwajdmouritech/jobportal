using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Models;

public class EmployeeInfo
{
    [Key]
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? CollegeName { get; set; }

    public string? Qualification { get; set; }

    public int? Percentage { get; set; }

    public string? Speciality { get; set; }

    public string? TechnologiesStudied { get; set; }

    public string? SoftSkill { get; set; }

    public string? Internship { get; set; }

    public string? Certification { get; set; }

    public string? EmailId { get; set; }

    public int? PhoneNumber { get; set; }

    public string? LinkedinUrl { get; set; }

    public int? CityId { get; set; }

    public string? OfferLetter { get; set; }

    public int? Experience { get; set; }
    public bool IsActive {get;set;}
    
    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedOn { get; set; }
    [Timestamp]
    [ConcurrencyCheck]
    public byte[] RowTimeStamp { get; set; }

    public virtual City? City { get; set; }

    public List<EmployeeDocument> EmployeeDocuments {get;set;}
}
