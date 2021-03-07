using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SharedKernel;

namespace DeltaCenter.Core.Entities
{
    public class Visit:BaseModel
    {
        public int PatientId { get; set; }
        public VisitType VisitType { get; set; }
        [MaxLength(500)]
        public string PatientComplain { get; set; }

        [MaxLength(1000)]
        public string Notes { get; set; }

        public virtual IEnumerable<VisitDiagnose> VisitDiagnoses { get; set; }
        public virtual IEnumerable<VisitMedication> VisitMedications { get; set; }

        [ForeignKey(name:nameof(PatientId))]
        public virtual Patient Patient { get; set; }
    }
}
