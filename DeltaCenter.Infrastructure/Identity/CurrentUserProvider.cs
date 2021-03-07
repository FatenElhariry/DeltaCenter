using DeltaCenter.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace DeltaCenter.Infrastructure.Identity
{
    public class CurrentUserProvider : ICurrentUserProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CurrentUserProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string UserId => _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

        public string UserName => _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;

        public List<string> Roles => _httpContextAccessor.HttpContext.User.FindAll(ClaimTypes.Role).ToList().Select(claim => claim.Value).ToList();
    }
}
