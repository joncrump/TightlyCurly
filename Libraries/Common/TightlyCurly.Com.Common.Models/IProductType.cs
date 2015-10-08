namespace TightlyCurly.Com.Common.Models
{
    public interface IProductType : IModel
    {
        string Type { get; set; }
        string Description { get; set; }
    }
}
