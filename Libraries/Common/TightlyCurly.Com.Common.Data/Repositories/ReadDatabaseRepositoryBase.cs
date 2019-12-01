using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TightlyCurly.Com.Common.Data.QueryBuilders;
using TightlyCurly.Com.Common.Data.Repositories.Strategies;
using TightlyCurly.Com.Common.Extensions;
using TightlyCurly.Com.Common.Helpers;

namespace TightlyCurly.Com.Common.Data.Repositories
{
    public abstract class ReadDatabaseRepositoryBase<TInterface, TModel> : DatabaseRepositoryBase
        where TModel : class, TInterface, new()
    {
        protected readonly IMapper Mapper;
        protected readonly IQueryBuilder QueryBuilder;

         protected ReadDatabaseRepositoryBase(string databaseName, IDatabaseFactory databaseFactory, IMapper mapper,
            IQueryBuilder queryBuilder, IBuilderStrategyFactory builderStrategyFactory)
            : base(databaseName, databaseFactory, builderStrategyFactory)
        {
            Mapper = Guard.ThrowIfNull("mapper", mapper);
            QueryBuilder = Guard.ThrowIfNull("queryBuilder", queryBuilder);
        }

        public virtual IEnumerable<TInterface> Get(Expression filterExpression = null, 
            ILoadOptions loadOptions = null)
            //bool includeParameters = true, 
            //BuildMode buildMode = BuildMode.Single)
        {
            throw new NotImplementedException();
            //var values =
            //    ExecuteMultiple<TModel>(QueryBuilder.BuildSelectQuery(filterExpression, true, includeParameters),
            //        buildMode);

            //return values;
        }

        //{
        //    if (filterExpression.IsNull())
        //    {
        //        return Get();
        //    }

        //    var castExpression = filterExpression as Expression<Func<TModel, bool>>;

        //    if (castExpression.IsNull())
        //    {
        //        throw new InvalidOperationException("Type of predicate parameter must be type of {0}"
        //            .FormatString(typeof(TModel).ToString()));
        //    }

        //    return Get(castExpression);
        //}
    }
}
