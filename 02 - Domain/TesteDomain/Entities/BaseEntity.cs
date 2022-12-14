using System;

namespace Teste.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
