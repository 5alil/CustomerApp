using AutoMapper;
using CustomerApp.Repository.IRepository;
using CustomerApp.Repository.UnitOfWork;
using CustomerApp.Services.IService;
using CustomerApp.Services.Services;
using CustomerApp.UI.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CustomerApp.UI.GenericController
{
#pragma warning disable CS1591
    public abstract class GenericController<T,TDto> : ControllerBase where T : class 
    {
        private readonly IMapper _mapper;
        private IGenericService<T> _entityService;
        //private Expression<Func<T, object>>[] _includeProperties;
        public GenericController(IGenericService<T> entityService, IMapper mapper)
        {
            _mapper = mapper;
            _entityService = entityService;
            //_includeProperties = includeProperties;
        }

        // GET api/entities
        [HttpGet]
        public IEnumerable<TDto> Get()
        {
            // Use Auto Mapper Here
            IEnumerable<T> source = _entityService.GetAll() as IEnumerable<T>;
            var result = _mapper.Map<List<TDto>>(source);
            return result;
        }

        // GET api/entities/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    T source = _entityService.Get(id);
        //    TDto res = _mapper.Map<TDto>(source);
        //    return "string";
        //}
    }
}
