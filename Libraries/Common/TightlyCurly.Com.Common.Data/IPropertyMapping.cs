namespace TightlyCurly.Com.Common.Data
{
    public interface IPropertyMapping
    {
        string PropertyName { get; set; }
        string ParameterName { get; set; }
        string LazyLoader { get; set; }
        string FieldType { get; set; }
        string Field { get; set; }
        bool AllowNull { get; set; }
        bool IsIdentity { get; set; }
        IJoinMapping JoinMapping { get; set; }
        IMethodCache MethodCache { get; set; }
    }
}
