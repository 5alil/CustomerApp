using CustomerApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Repository.IRepository
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        // If you need to customize your entity actions you can put here  
        // Or add new business functions for this entity 
    }
}
