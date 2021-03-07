using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaCenter.Infrastructure.Dtos
{
    public class VisitMedicationDto
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public int MedicationId { get; set; }
        public string Dose { get; set; }
    }
}
