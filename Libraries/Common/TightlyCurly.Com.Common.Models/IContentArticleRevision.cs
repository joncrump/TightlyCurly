using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IContentArticleRevision : IModel
    {
        string VersionNumber { get; set; }
        bool IsCurrent { get; set; }
        string Notes { get; set; }
        Guid ContentArticleId { get; set; }
        IContentArticle Article { get; set; }
    }
}
