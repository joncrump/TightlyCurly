using TightlyCurly.Com.Common.Data.Helpers;

namespace TightlyCurly.Com.Common.Data.QueryBuilders.Strategies.TSql
{
    public class CountQueryBuilderStrategy : QueryBuilderStrategyBase, IQueryBuilderStrategy
    {
        private readonly IObjectMappingFactory _objectMappingFactory;
        private readonly IDatabaseConfiguration _databaseConfiguration;

        public CountQueryBuilderStrategy(IFieldHelper fieldHelper, IObjectMappingFactory objectMappingFactory, 
            IDatabaseConfiguration databaseConfiguration) : base(fieldHelper)
        {
            _objectMappingFactory = objectMappingFactory.EnsureIsNotNull(nameof(objectMappingFactory));
            _databaseConfiguration = databaseConfiguration.EnsureIsNotNull(nameof(databaseConfiguration));
        }

        public QueryInfo BuildQuery<TValue>(dynamic parameters) where TValue : class
        {
            var mapping = _objectMappingFactory.GetMappingForType(typeof(TValue), _databaseConfiguration.MappingKind);
            var table = mapping.DataSource;
            var count = mapping.CountField;

            return new QueryInfo($"SELECT COUNT({count}) AS {count} FROM {table};");
        }
    }
}
