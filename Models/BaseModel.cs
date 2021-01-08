using System;
using System.ComponentModel.DataAnnotations;

namespace NespressoReviewsApi.Models
{
    public abstract class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set;}
    }
}