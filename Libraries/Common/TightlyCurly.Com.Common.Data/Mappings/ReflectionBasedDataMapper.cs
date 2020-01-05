using System;
using System.Reflection;
using TightlyCurly.Com.Common.Data.Attributes;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public class ReflectionBasedDataMapper : IDataMapper
    {
        public TypeMapping GetMappingFor<TValue>()
        {
            return GetMappingForType(typeof(TValue));
        }

        public TypeMapping GetMappingForType(Type objectType)
        {
            objectType.ThrowIfNull(nameof(objectType));

            return BuildMapping(objectType);
        }

        private TypeMapping BuildMapping(Type objectType)
        {
            var typeMapping = new TypeMapping();

            BuildTableMapping(objectType, typeMapping);
            BuildPropertyMappings(objectType, typeMapping);

            return typeMapping;
        }

        private void BuildPropertyMappings(Type objectType, TypeMapping typeMapping)
        {
            var propertyInfos = objectType.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                BuildPropertyMapping(propertyInfo, typeMapping);
            }
        }

        private void BuildPropertyMapping(PropertyInfo propertyInfo, TypeMapping typeMapping)
        {
            var fieldAttribute = (FieldMetadataAttribute) propertyInfo.GetCustomAttribute(typeof(
                FieldMetadataAttribute));
            var joinAttribute = (JoinAttribute) propertyInfo.GetCustomAttribute(typeof(JoinAttribute));
            var countAttribute =
                (CountMetadataAttribute) propertyInfo.GetCustomAttribute(typeof(CountMetadataAttribute));
            
            var propertyMapping = new PropertyMapping();

            BuildFromFieldAttribute(propertyInfo, propertyMapping, fieldAttribute);
            BuildFromCountAttribute(typeMapping, countAttribute);
            BuildFromJoinAttribute(propertyMapping, joinAttribute);
            
            typeMapping.PropertyMappings.Add(propertyMapping);
        }

        private void BuildFromJoinAttribute(PropertyMapping propertyMapping, JoinAttribute joinAttribute)
        {
            if (joinAttribute == null)
            {
                return;
            }

            var joinMapping = new JoinMapping
            {
                JoinType = joinAttribute.JoinType,
                LeftKey = joinAttribute.LeftKey,
                RightKey = joinAttribute.RightKey,
                JoinTable = joinAttribute.JoinTable,
                JoinTableLeftKey = joinAttribute.JoinTableLeftKey,
                JoinTableRightKey = joinAttribute.JoinTableRightKey,
                JoinTableJoinType = joinAttribute.JoinTableJoinType,
                ParentProperty = joinAttribute.ParentProperty,
                ChildProperty = joinAttribute.ChildProperty
            };

            propertyMapping.JoinMapping = joinMapping;
        }

        private void BuildFromCountAttribute(TypeMapping typeMapping, CountMetadataAttribute countAttribute)
        {
            if (countAttribute == null)
            {
                return;
            }

            typeMapping.CountField = countAttribute.FieldName;
            typeMapping.CountAlias = countAttribute.FieldAlias;
        }

        private static void BuildFromFieldAttribute(PropertyInfo propertyInfo, PropertyMapping propertyMapping,
            FieldMetadataAttribute fieldAttribute)
        {
            propertyMapping.PropertyName = propertyInfo.Name;
            propertyMapping.DatabaseType = fieldAttribute.DbType;
            propertyMapping.ParameterName = fieldAttribute.ParameterName;
            propertyMapping.IsIdentity = fieldAttribute.IsIdentity;
            propertyMapping.AllowDbNull = fieldAttribute.AllowDbNull;
            propertyMapping.IsPrimaryKey = fieldAttribute.IsPrimaryKey;
            propertyMapping.Order = fieldAttribute.Order ?? 0;
            propertyMapping.IsPrimitive = propertyInfo.PropertyType.IsPrimitive;
            propertyMapping.Field = fieldAttribute.FieldName;
        }

        private void BuildTableMapping(Type objectType, TypeMapping mapping)
        {
            var tableAttribute = (TableAttribute)objectType.GetCustomAttribute(typeof(TableAttribute));

            mapping.DataSource = tableAttribute.Name;
            mapping.Type = objectType;
        }
    }
}