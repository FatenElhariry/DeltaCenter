using AutoMapper;
using DeltaCenter.Core.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BaseApiController<TEntity,TEntityDto> : ControllerBase where TEntity : BaseModel
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;
        protected readonly IRepository<TEntity> _repo;
        public BaseApiController(IRepository<TEntity> repo, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repo = repo;
        }
        [HttpGet]
        public virtual IActionResult Get()
        {
            return Ok(_repo.All.ToList());
        }
        [HttpGet("{Id}")]
        public virtual IActionResult Get([FromRoute] int Id)
        {
            return Ok(_repo.Find(Id));
        }


        [HttpPost]
        public virtual IActionResult Post(TEntityDto entity)
        {
            var _entity = _mapper.Map<TEntityDto, TEntity>(entity);
            _repo.Insert(_entity);
            _unitOfWork.SaveChanges();
            return Ok(_entity);
        }

        [HttpPut("{Id}")]
        public virtual IActionResult Put([FromRoute] int Id, TEntityDto entity)
        {
            var _entity = _repo.Find(Id);
            _entity = _mapper.Map<TEntityDto, TEntity>(entity, _entity);
            _repo.Update(_entity);
            _unitOfWork.SaveChanges();
            return Ok(entity);
        }

        [HttpDelete]
        public virtual IActionResult Delete([FromRoute] int Id)
        {
            _repo.Delete(Id);
            _unitOfWork.SaveChanges();
            return Ok();
        }
    }
}
