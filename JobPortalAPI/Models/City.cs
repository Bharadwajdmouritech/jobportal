﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Models;

public class City
{
     [Key]
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public string CityState { get; set; } = null!;
    public bool IsActive {get;set;}
    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedOn { get; set; }

    [Timestamp]
    [ConcurrencyCheck]
    public byte[] RowTimeStamp { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual ICollection<EmployeeInfo> EmployeeInfos { get; set; } = new List<EmployeeInfo>();

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
}
