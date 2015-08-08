using TightlyCurly.Com.Common.Data.Repositories;

namespace TightlyCurly.Com.Common.Data
{
    public interface IEntityRepository<TModel> : IWriteRepository<TModel>,
        IReadRepository<TModel>
    {
    }
}
