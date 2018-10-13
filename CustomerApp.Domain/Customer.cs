using CustomerApp.Domain.Audit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Domain
{
    public class Customer : IAuditable,IDeletable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string IdentityNumber { get; set; }
        public string PassportNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public List<CustomerDetail> Details { get; set; }
    }
}
