using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Repository.Common;

public interface ICrudRepository<TEntity> : ICreateUpdateRepository<TEntity>
    where TEntity : GenericEntity
{
    bool DeleteById(long id);
    bool Delete(TEntity entity);
}