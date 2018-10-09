using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Dto.Customer
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string IdentityNumber { get; set; }
        public string PassportNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public List<CustomerDetailDto> CustomerDetails { get; set; }
    }
}
