namespace MedCenter_API_CSharp.Repositories.Common;

using Models.Generic;

public interface IReadOnlyRepository<TEntity> where TEntity : GenericEntity
{
    TEntity GetById(long id);
    bool ExistsById(long id);
}