using DeltaCenter.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaCenter.Infrastructure.Dtos
{
    public class VisitDto
    {
        public int PatientId { get; set; }
        public VisitType VisitType { get; set; }
        public string PatientComplain { get; set; }

        public string Notes { get; set; }

        public virtual IEnumerable<VisitDiagnoseDto> VisitDiagnoses { get; set; }
        public virtual IEnumerable<VisitMedicationDto> VisitMedications { get; set; }

    }
}
