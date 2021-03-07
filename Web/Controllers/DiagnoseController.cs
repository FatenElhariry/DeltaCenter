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
    public class DiagnoseController : BaseApiController<Diagnose,DiagnoseDto>
    {

        public DiagnoseController(IRepository<Diagnose> repo, IUnitOfWork unitOfWork, IMapper mapper) : base(repo ,unitOfWork, mapper)
        {
        }
       
    }
}
