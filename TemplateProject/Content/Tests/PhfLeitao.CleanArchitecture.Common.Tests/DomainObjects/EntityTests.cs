using System;
using Xunit;

namespace PhfLeitao.CleanArchitecture.Core.Common.Tests.DomainObjects
{ 
    public class EntityTests
    {
        #region Contructor
        [Fact(DisplayName = "Constructor: Erro ao incluir id default")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_Constructor_ShouldThrowArgumentExceptionOnDefaultId()
        {
            //Arrange, Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new ConcreteEntity(default));
            Assert.Equal("O id não pode ser o valor padrão (Parameter 'id')", exception.Message);
        }
        #endregion

        #region Equals

        [Fact(DisplayName = "Equals: Igual - Mesmo ID")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_Equals_SameIdShouldBeEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity(entityA.Id);

            //Act
            var result = entityA.Equals(entityB);

            //Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Equals: Igual - Mesma Referência")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_Equals_SameReferenceShouldBeEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();
            entityB = entityA;

            //Act
            var result = entityA.Equals(entityB);

            //Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Equals: Diferente - IDs diferentes")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_Equals_DifferentIdShouldBeNotEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();

            //Act
            var result = entityA.Equals(entityB);

            //Assert
            Assert.False(result);
        }

        [Fact(DisplayName = "Equals: Diferente - Referências diferentes")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_Equals_DifferentReferenceShouldBeNotEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();

            //Act
            var result = entityA.Equals(entityB);

            //Assert
            Assert.False(result);
        }

        [Fact(DisplayName = "Equals: Diferente - comparação com null")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_Equals_NullReferenceShouldBeNotEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();
            entityB = null;
;
            //Act
            var result = entityA.Equals(entityB);

            //Assert
            Assert.False(result);
        }

        [Fact(DisplayName = "Equals: Diferente - comparação com outro tipo de objeto")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_Equals_CompareTwoDifferentTypesShouldBeDifferent()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new DateTime(2020,1,1);

            //Act
            var result = entityA.Equals(entityB);

            //Assert
            Assert.False(result);
        }

        #endregion

        #region Operator ==

        [Fact(DisplayName = "Operator ==: Igual - Mesmo ID")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorEqual_SameIdShouldBeEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity(entityA.Id);

            //Act
            var result = entityA == entityB;

            //Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Operator ==: Igual - Mesma Referência")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorEqual_SameReferenceShouldBeEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();
            entityB = entityA;

            //Act
            var result = entityA == entityB;

            //Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Operator ==: Diferente - IDs diferentes")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorEqual_DifferentIdShouldBeNotEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();

            //Act
            var result = entityA == entityB;

            //Assert
            Assert.False(result);
        }

        [Fact(DisplayName = "Operator ==: Diferente - Referências diferentes")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorEqual_DifferentReferenceShouldBeNotEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();

            //Act
            var result = entityA == entityB;

            //Assert
            Assert.False(result);
        }

        [Fact(DisplayName = "Operator ==: Diferente - comparação com null")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorEqual_NullReferenceShouldBeNotEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();
            entityB = null;
            ;
            //Act
            var result = entityA == entityB;

            //Assert
            Assert.False(result);
        }

        [Fact(DisplayName = "Operator ==: Igual - Ambos os objetos a null")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorEqual_BothNullReferenceShouldBeEqual()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();
            entityA = null;
            entityB = null;
            
            //Act
            var result = entityA == entityB;

            //Assert
            Assert.True(result);
        }

        #endregion

        #region Operator !=

        [Fact(DisplayName = "Operator !=: Igual - Mesmo ID")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorDifferent_SameIdShouldNotBeDifferent()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity(entityA.Id);

            //Act
            var result = entityA != entityB;

            //Assert
            Assert.False(result);
        }

        [Fact(DisplayName = "Operator !=: Igual - Mesma Referência")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorDifferent_SameReferenceShouldNotBeDifferent()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();
            entityB = entityA;

            //Act
            var result = entityA != entityB;

            //Assert
            Assert.False(result);
        }

        [Fact(DisplayName = "Operator !=: Diferente - IDs diferentes")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorDifferent_DifferentIdShouldBeDifferent()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();

            //Act
            var result = entityA != entityB;

            //Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Operator !=: Diferente - Referências diferentes")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorDifferent_DifferentReferenceShouldBeDifferent()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();

            //Act
            var result = entityA != entityB;

            //Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Operator !=: Diferente - comparação com null")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorDifferent_NullReferenceShouldBeDifferent()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();
            entityB = null;

            //Act
            var result = entityA != entityB;

            //Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Operator !=: Igual - Ambos os objetos a null")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_OperatorDifferent_BothNullReferenceShouldNotBeDifferent()
        {
            //Arrange
            var entityA = new ConcreteEntity();
            var entityB = new ConcreteEntity();
            entityA = null;
            entityB = null;

            //Act
            var result = entityA != entityB;

            //Assert
            Assert.False(result);
        }

        #endregion

        #region GetHashCode

        [Fact(DisplayName = "GetHashCode: Precisa seguir a definição do hash")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_GetHashCode_ShouldContainIdHash()
        {
            //Arrange
            var entity = new ConcreteEntity();
            var expected = (entity.GetType().GetHashCode() * 907) + entity.Id.GetHashCode();

            //Act
            var result = entity.GetHashCode();

            //Assert
            Assert.Equal(expected, result);
        }

        #endregion

        #region ToString

        [Fact(DisplayName = "ToString: Nome do Tipo e Id")]
        [Trait("Core.Common.DomainObjetcs", "Entity")]
        public void Entity_ToString_ShouldReturnFormattedString()
        {
            //Arrange
            var entity = new ConcreteEntity();
            var expected = $"ConcreteEntity [Id={entity.Id}]";

            //Act
            var result = entity.ToString();

            //Assert
            Assert.Equal(expected, result);
        }

        #endregion
    }
}
