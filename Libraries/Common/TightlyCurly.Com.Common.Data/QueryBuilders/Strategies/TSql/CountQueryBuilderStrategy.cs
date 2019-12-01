using TightlyCurly.Com.Common.Data.Helpers;
using TightlyCurly.Com.Common.Data.Mappings;

namespace TightlyCurly.Com.Common.Data.QueryBuilders.Strategies.TSql
{
    public class CountQueryBuilderStrategy : QueryBuilderStrategyBase, IQueryBuilderStrategy
    {
        private readonly IObjectMapperFactory _objectMappingFactory;
        private readonly IDatabaseConfiguration _databaseConfiguration;

        public CountQueryBuilderStrategy(IFieldHelper fieldHelper, IObjectMapperFactory objectMappingFactory, 
            IDatabaseConfiguration databaseConfiguration) : base(fieldHelper)
        {
            _objectMappingFactory = objectMappingFactory.ThrowIfNull(nameof(objectMappingFactory));
            _databaseConfiguration = databaseConfiguration.ThrowIfNull(nameof(databaseConfiguration));
        }

        public QueryInfo BuildQuery<TValue>(dynamic parameters) where TValue : class
        {
            var mapper = _objectMappingFactory.GetMapperFor<TValue>(_databaseConfiguration.MappingKind);
            var mapping = mapper.GetMappingFor<TValue>();
            var table = mapping.DataSource;
            var count = mapping.CountField;

            return new QueryInfo($"SELECT COUNT({count}) AS {count} FROM {table};");
        }
    }
}
