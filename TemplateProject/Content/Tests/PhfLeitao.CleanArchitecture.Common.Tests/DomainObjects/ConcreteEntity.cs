using PhfLeitao.CleanArchitecture.Core.Common.DomainObjects;
using System;

namespace PhfLeitao.CleanArchitecture.Core.Common.Tests.DomainObjects
{ 
    public class ConcreteEntity : Entity<Guid>
    {
        public ConcreteEntity() : base(Guid.NewGuid()) { }
        public ConcreteEntity(Guid id) : base(id) { }
        public override bool IsValid()
        {
            return true;
        }
    }
}
