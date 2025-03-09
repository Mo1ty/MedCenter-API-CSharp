namespace MedCenter_API_CSharp.Repository.Common;

using Models.Generic;

public interface IReadOnlyRepository<TEntity> where TEntity : GenericEntity
{
    TEntity GetById(long id);
    bool ExistsById(long id);
}