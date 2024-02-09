using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Models;

public class JobFunction
{
     [Key]
    public int JobId { get; set; }

    public string? Job { get; set; }

    public bool IsActive {get;set;}
    
    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedOn { get; set; }

    [ConcurrencyCheck]
    public byte[]? RowTimeStamp { get; set; }

    public virtual ICollection<Jd> Jds { get; set; } = new List<Jd>();
}
