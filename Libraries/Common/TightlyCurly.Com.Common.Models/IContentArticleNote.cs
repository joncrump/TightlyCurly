using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IContentArticleNote : IModel
    {
        Guid EnteredByUserId { get; set; }
        IUser EnteredBy { get; set; }
        string Note { get; set; }
        Guid ContentArticleId { get; set; }
    }
}
