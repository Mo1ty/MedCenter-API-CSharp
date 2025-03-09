using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Repository.Common;

public interface IImmutableRepository<TEntity> : IReadOnlyRepository<TEntity>
    where TEntity : GenericEntity
{
    TEntity Add(TEntity entity);
}