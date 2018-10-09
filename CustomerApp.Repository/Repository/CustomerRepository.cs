using CustomerApp.Data;
using CustomerApp.Domain;
using CustomerApp.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Repository.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        // 1- You can override the methods in generic repository for this repository
        // 2- Impelement the methods of this entity repository (Customer Repository)
        // 3- Create new methods for this entity (Customer)
        public CustomerRepository(CustomerContext context) : base(context)
        {

        }

        public async Task<Customer> GetSingleAsyn(int id)
        {
            return await _context.Set<Customer>().FindAsync(id);
        }

        public override void Update(Customer t, object key)
        {
            Customer exist = _context.Set<Customer>().Find(key);
            if (exist != null)
            {
                t.CreatedBy = exist.CreatedBy;
                t.CreatedOn = exist.CreatedOn;
                base.Update(t, key);
            }
            
        }
        
    }
}
