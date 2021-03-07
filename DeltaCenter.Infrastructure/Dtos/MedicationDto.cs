using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaCenter.Infrastructure.Dtos
{
    public class MedicationDto
    {
        public int Id { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }

        public string Notes { get; set; }
    }
}
