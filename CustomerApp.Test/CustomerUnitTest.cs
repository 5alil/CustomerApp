using AutoMapper;
using CustomerApp.Dto.Customer;
using CustomerApp.Repository.IRepository;
using CustomerApp.Repository.UnitOfWork;
using CustomerApp.UI.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace CustomerApp.Test
{
    public class CustomerUnitTest
    {
        private Mock<ICustomerRepository> customerRepositoryMock;
        private Mock<IUnitOfWork> unitOfWorkMock;
        private Mock<IMapper> mapperMock;

        private CustomerController controller;
        public CustomerUnitTest()
        {
            customerRepositoryMock = new Mock<ICustomerRepository>();
            unitOfWorkMock = new Mock<IUnitOfWork>();
            mapperMock = new Mock<IMapper>();

            controller = new CustomerController(unitOfWorkMock.Object, customerRepositoryMock.Object, mapperMock.Object);
        }
        [Fact]
        public void TestGetCustomers()
        {
            IEnumerable<CustomerDto> customers = controller.Get();
        }
    }
}
