using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalAPI.Models
{
    public class EmployeeDocument
    {
        [Key]
        public int? DocumentId{get;set;}
        public int? EmployeeId { get; set; }
        
        public byte[]? GraduationMarksheet {get;set;}
        public byte[]? PassingCertificate {get;set;}
        public byte[]? AadharCard {get;set;}
        public byte[]? PANCard {get;set;}
        public byte[]? PassportDoc {get;set;}
        public byte[]? IdentityPhoto {get;set;}
        public byte[]? TenthMarksheet {get;set;}
        public byte[]? TwelthMarksheet{get;set;}
        public byte[]? Resume {get;set;}
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        [Timestamp]
        [ConcurrencyCheck]
        public byte[] RowTimeStamp { get; set; }
    }
}