using SharedKernel;
using System.ComponentModel.DataAnnotations.Schema;


namespace DeltaCenter.Core.Entities
{
    public class VisitDiagnose:BaseModel
    {
        public int VisitId { get; set; }
        public int DiagnoseId { get; set; }
        public DiagnoseType DiagnoseType { get; set; }

        [ForeignKey(name:nameof(VisitId))]
        public virtual Visit Visit { get; set; }

        [ForeignKey(name: nameof(DiagnoseId))]
        public virtual Diagnose Diagnose { get; set; }
    }
}
