using AutoMapper;
using CustomerApp.Domain;
using CustomerApp.Dto.Customer;
using CustomerApp.Repository.IRepository;
using CustomerApp.Repository.UnitOfWork;
using CustomerApp.Services.Services;
using CustomerApp.UI.GenericController;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApp.UI.Controllers
{
#pragma warning disable CS1591
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : GenericController<Customer,CustomerDto>
    {
        private readonly IMapper _mapper;
        private CustomerService _customerService;

        public CustomerController(IUnitOfWork unitOfWork, ICustomerRepository customerRepository, IMapper mapper)
            : base(
                 new CustomerService(unitOfWork, customerRepository),
                 mapper)
        {
            _mapper = mapper;
            _customerService = new CustomerService(unitOfWork, customerRepository);
        }
    }
}