using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaCenter.Infrastructure.Dtos
{
    public class DiagnoseDto
    {
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public bool IsMain { get; set; }
        public string Notes { get; set; }
        public int? ParentId { get; set; }
    }
}
