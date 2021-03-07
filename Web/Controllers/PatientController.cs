using AutoMapper;
using DeltaCenter.Core.Entities;
using DeltaCenter.Core.Interfaces;
using DeltaCenter.Infrastructure.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : BaseApiController<Patient, PatientDto>
    {

        public PatientController(IRepository<Patient> repo, IUnitOfWork unitOfWork, IMapper mapper):base(repo, unitOfWork, mapper)
        {
        }
      
    }
}
