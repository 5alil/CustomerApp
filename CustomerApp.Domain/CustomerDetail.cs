using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Domain
{
    public class CustomerDetail
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
