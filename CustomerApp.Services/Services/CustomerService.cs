using CustomerApp.Domain;
using CustomerApp.Repository.IRepository;
using CustomerApp.Repository.UnitOfWork;
using CustomerApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Services.Services
{
    public class CustomerService : GenericService<Customer> , ICustomerService
    {
        IUnitOfWork _unitOfWork;
        ICustomerRepository _customerRepository;

        public CustomerService(IUnitOfWork unitOfWork, ICustomerRepository customerRepository)
            : base(unitOfWork, customerRepository)
        {
            _unitOfWork = unitOfWork;
            _customerRepository = customerRepository;
        }
    }
}
