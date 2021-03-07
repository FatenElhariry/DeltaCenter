using AutoMapper;
using DeltaCenter.Core.Entities;
using DeltaCenter.Core.Interfaces;
using DeltaCenter.Infrastructure.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class MedicationController : BaseApiController<Medication,MedicationDto>
    {
        public MedicationController(IRepository<Medication> repo,IUnitOfWork unitOfWork, IMapper mapper) : base(repo,unitOfWork, mapper)
        {
        }

      
    }
}
