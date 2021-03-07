using DeltaCenter.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaCenter.Infrastructure.Dtos
{
    public class VisitDiagnoseDto
    {
        public int VisitId { get; set; }
        public int DiagnoseId { get; set; }
        public DiagnoseType DiagnoseType { get; set; }

    }
}
