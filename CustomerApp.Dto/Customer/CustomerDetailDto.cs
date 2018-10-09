using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Dto.Customer
{
    public class CustomerDetailDto
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
    }
}
