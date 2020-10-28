using System;

namespace NespressoReviewsApi.Dtos
{
    public abstract class CreationDtoBase
    {
        public Guid Id { get; set; }        
        public DateTime CreatedDate { get; set; }

        public CreationDtoBase()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
    }
}