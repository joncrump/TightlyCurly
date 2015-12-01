using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using TightlyCurly.Com.Common.Data.Constants;
using TightlyCurly.Com.Common.Extensions;

namespace TightlyCurly.Com.Common.Data
{
    public class FieldHelper : IFieldHelper
    {
        private readonly IObjectMappingFactory _objectMappingFactory;
        private readonly Dictionary<string, SqlDbType> _fieldTypeMappings = new Dictionary<string, SqlDbType>
        {
            { DatabaseTypes.NVarchar, SqlDbType.NVarChar},
            { DatabaseTypes.Int, SqlDbType.Int },
            { DatabaseTypes.Xml, SqlDbType.Xml },
            { DatabaseTypes.Guid, SqlDbType.UniqueIdentifier },
            { DatabaseTypes.SmallDateTime, SqlDbType.SmallDateTime }
        };

        public FieldHelper(IObjectMappingFactory objectMappingFactory)
        {
            _objectMappingFactory = Guard.EnsureIsNotNull("objectMappingFactory", objectMappingFactory);
        }

        public TableObjectMapping BuildFields<TValue>(IEnumerable<string> desiredFields = null, 
            string tableName = null, TValue model = default(TValue), bool ignoreIdentity = false, 
            string alias = null, string instancePropertyName = null) 
            where TValue : class
        {
            var fields = new Dictionary<string, FieldParameterMapping>();
            var mapping = _objectMappingFactory.GetMappingFor<TValue>();

            if (tableName.IsNullOrEmpty())
            {
                tableName = mapping.DataSource; //tableAttribute.Name;
            }

            foreach (var propertyMapping in mapping.PropertyMappings)//var property in type.GetProperties())
            {
                //var attribute =
                //    (FieldMetadataAttribute)property.GetCustomAttributes(typeof(FieldMetadataAttribute), true).FirstOrDefault();

                //if (attribute.IsNull())
                //{
                //    continue;
                //}

                // ReSharper disable once PossibleNullReferenceException
                if (ignoreIdentity && propertyMapping.IsIdentity)
                {
                    continue;
                }

                // ReSharper disable once AssignNullToNotNullAttribute
                if ((desiredFields.IsNotNullOrEmpty() && !desiredFields.Contains(propertyMapping.PropertyName)))
                {
                    continue;
                }

                // ReSharper disable once PossibleNullReferenceException
                fields.Add(propertyMapping.PropertyName, new FieldParameterMapping(propertyMapping.Field, 
                    propertyMapping.ParameterName.IsNullOrEmpty() 
                        ? "@{0}".FormatString(propertyMapping.ParameterName.ToLower()) 
                        : propertyMapping.ParameterName, 
                            GetDbTypeFromString(propertyMapping.FieldType),
                    EqualityComparer<TValue>.Default.Equals(model, default(TValue)) ? null : propertyMapping.MethodCache.GetPropertyValue(propertyMapping.PropertyName, model), 
                        propertyMapping.IsIdentity, alias));
            }

            if (fields.IsNullOrEmpty())
            {
                throw new InvalidOperationException("Cannot build query.  Model has no data attributes.");
            }

            return new TableObjectMapping
            {
                TableName = tableName,
                FieldMappings = fields,
                Alias = alias,
                InstancePropertyName = instancePropertyName
            };
        }

        public IEnumerable<IDbDataParameter> ExtractParameters(TableObjectMapping tableFieldInfo, bool ignoreIdentity)
        {
            if (tableFieldInfo.IsNull() || tableFieldInfo.FieldMappings.IsNullOrEmpty())
            {
                return Enumerable.Empty<IDbDataParameter>();
            }

            return tableFieldInfo
                .FieldMappings
                .Select(f => f.Value)
                .Where(f => !ignoreIdentity || !f.IsIdentity)
                .SafeSelect(f => new SqlParameter(f.ParameterName, f.DbType)
                {
                    Value = f.Value.IsNull() ? DBNull.Value : f.Value
                })
                .ToList();
        }

        private SqlDbType GetDbTypeFromString(string fieldType)
        {
            fieldType = fieldType.ToLower();

            return _fieldTypeMappings[fieldType];
        }
    }
}
