using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IContentArticle : IMetaItem, IModel
    {
        bool? IsActive { get; set; }
        Guid ContentItemId { get; set; }
        string Title { get; set; }
        IEnumerable<IContentArticleNote> Notes { get; set; }
        // Contains article revisions, such as edited by, text, etc.
        IEnumerable<IContentArticleRevision> Revisions { get; set; }
        // Contains locale, description, text, etc.
        IEnumerable<IContentArticleData> Data { get; set; }
    }
}
