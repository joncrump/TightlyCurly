namespace TightlyCurly.Com.Common.Models
{
    public interface IProductCategory : IModel
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
