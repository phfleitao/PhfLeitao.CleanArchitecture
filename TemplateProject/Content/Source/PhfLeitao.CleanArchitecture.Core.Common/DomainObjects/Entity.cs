using System;

namespace PhfLeitao.CleanArchitecture.Core.Common.DomainObjects
{
    public abstract class Entity<TId>
    {
        public TId Id { get; private set; }

        protected Entity(TId id)
        {
            if (Equals(id, default(TId)))
                throw new ArgumentException("O id não pode ser o valor padrão", "id");

            Id = id;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Entity<TId>;

            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Id.Equals(other.Id);
        }

        public static bool operator ==(Entity<TId> leftEntity, Entity<TId> rightEntity)
        {
            if (leftEntity is null && rightEntity is null) return true;
            if (leftEntity is null || rightEntity is null) return false;

            return leftEntity.Equals(rightEntity);
        }

        public static bool operator !=(Entity<TId> leftEntity, Entity<TId> rightEntity)
        {
            return !(leftEntity == rightEntity);
        }

        public override int GetHashCode()
        {
            //Diminui a probabilidade do hashCode de uma entidade ser igual a uma outra entidade
            //907 é apenas um número aleatório
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }

        public abstract bool IsValid();
    }
}
