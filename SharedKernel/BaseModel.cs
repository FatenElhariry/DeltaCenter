using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SharedKernel
{
    public class BaseModel:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public String UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public String DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
