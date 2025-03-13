using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Repositories.Common;

public interface ICreateUpdateRepository<TEntity> : IImmutableRepository<TEntity> 
    where TEntity : GenericEntity
{
    bool Update(TEntity entity);
}