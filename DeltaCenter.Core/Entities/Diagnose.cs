using SharedKernel;

namespace DeltaCenter.Core.Entities
{
    public class Diagnose:BaseModel
    {
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public bool IsMain { get; set; }
        public string Notes { get; set; }
        public int? ParentId { get; set; }
    }
}
