namespace MedCenter_API_CSharp.Repository.Common;

using Models.Generic;

public interface ICrudRepository<TEntity> where TEntity : GenericEntity
{
    TEntity GetById(long id);
    bool ExistsById(long id);
    
    TEntity Add(TEntity entity);
    
    bool Update(TEntity entity);
    
    bool DeleteById(long id);
    bool Delete(TEntity entity);
}