﻿using TightlyCurly.Com.Common.Data;
using TightlyCurly.Com.Common.Data.QueryBuilders;
using TightlyCurly.Com.Common.Data.Repositories;
using TightlyCurly.Com.Common.Data.Repositories.Strategies;
using TightlyCurly.Com.Common.Helpers;
using TightlyCurly.Com.Common.Models;
using TightlyCurly.Com.Repositories.Models;

namespace TightlyCurly.Com.Repositories.Database
{
    public class DatabaseProductMetadataRepository : EntityModelDatabaseRepositoryBase<IProductMetadata, ProductMetadataDataModel>, 
        IProductMetadataRepository
    {
        public DatabaseProductMetadataRepository(string databaseName, IDatabaseFactory databaseFactory, IMapper mapper, IQueryBuilder queryBuilder, IBuilderStrategyFactory builderStrategyFactory) : base(databaseName, databaseFactory, mapper, queryBuilder, builderStrategyFactory)
        {
        }
    }
}
