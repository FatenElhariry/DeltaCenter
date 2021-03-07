using System.ComponentModel.DataAnnotations;
using SharedKernel;

namespace DeltaCenter.Core.Entities
{
    public class Medication:BaseModel
    {
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }

        [MaxLength(length:1000)]
        public string Notes { get; set; }

        public virtual VisitMedication PatientMedication { get; set; }
    }
}
