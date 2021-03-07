using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeltaCenter.Infrastructure.Dtos
{
    public class PatientDto
    {
        public String Name { get; set; }
        public string Mobile { get; set; }
        public DateTime BirthDate { get; set; }
        public string Notes { get; set; }
    }
}
