using System;
using SharedKernel;

namespace DeltaCenter.Core.Entities
{
    public class Patient:BaseModel
    {
        public String Name { get; set; }
        public string Mobile { get; set; }
        public DateTime BirthDate { get; set; }
        public string Notes { get; set; }

    }
}
