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
        
        public byte[]? GraduationMarksheet {get;set;}=null;
        public byte[]? PassingCertificate {get;set;}=null;
        public byte[]? AadharCard {get;set;}=null;
        public byte[]? PANCard {get;set;}=null;
        public byte[]? PassportDoc {get;set;}=null;
        public byte[]? IdentityPhoto {get;set;}=null;
        public byte[]? TenthMarksheet {get;set;}=null;
        public byte[]? TwelthMarksheet{get;set;}=null;
        public byte[]? Resume {get;set;}=null;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        [Timestamp]
        [ConcurrencyCheck]
        public byte[] RowTimeStamp { get; set; }
    }
}