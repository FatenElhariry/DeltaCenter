using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaCenter.Core.Interfaces
{
    public interface ICurrentUserProvider
    {
        public string UserId { get; }
        public String UserName { get; }

        public List<string> Roles { get;}

    }
}
