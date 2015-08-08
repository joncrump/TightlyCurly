using System.Linq.Expressions;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Data;
using TightlyCurly.Com.Common.Data.Repositories;

namespace TightlyCurly.Com.Providers.Repositories.Common
{
    public abstract class BasicPagingRepositoryProviderBase<TInterface, TRepository> 
        : ReadRepositoryProviderBase<TInterface, TRepository>
        where TRepository : IEntityRepository<TInterface>, IPagingRepository
        where TInterface : IModel
    {
        protected BasicPagingRepositoryProviderBase(TRepository repository) 
            : base(repository)
        {
        }

        public virtual PagingModel GetPage(Expression filterExpression = null, PagingInfo pagingInfo = null, 
            dynamic loadOptions = null)
        {
            return Repository.GetCriteriaByPage(filterExpression, pagingInfo, loadOptions);
        }
    }
}
