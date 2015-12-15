namespace TightlyCurly.Com.Common.Data.QueryBuilders.Strategies.TSql
{
    public class CountQueryBuilderStrategy : QueryBuilderStrategyBase, IQueryBuilderStrategy
    {
        private readonly IObjectMappingFactory _objectMappingFactory;

        public CountQueryBuilderStrategy(IFieldHelper fieldHelper, IObjectMappingFactory objectMappingFactory) : base(fieldHelper)
        {
            _objectMappingFactory = objectMappingFactory.EnsureIsNotNull("objectMappingFactory");
        }

        public QueryInfo BuildQuery<TValue>(dynamic parameters) where TValue : class
        {
            var mapping = _objectMappingFactory.GetMappingFor<TValue>();
            var table = mapping.DataSource;
            var count = mapping.CountField;

            return new QueryInfo($"SELECT COUNT({count}) AS {count} FROM {table};");
        }
    }
}
