using System.ComponentModel.DataAnnotations.Schema;
using SharedKernel;

namespace DeltaCenter.Core.Entities
{
    public class VisitMedication:BaseModel
    {
        public int VisitId { get; set; }
        public int MedicationId { get; set; }
        public string Dose { get; set; }

        [ForeignKey(name:nameof(MedicationId))]
        public virtual Medication Medication { get; set; }

        [ForeignKey(name:nameof(VisitId))]
        public virtual Visit Visit { get; set; }
    }
}
