using System;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public interface IJoinMapping
    {
        string JoinType { get; set; }
        string LeftKey { get; set; }
        string RightKey { get; set; }
        string JoinTable { get; set; }
        string JoinTableLeftKey { get; set; }
        string JoinTableRightKey { get; set; }
        string JoinTableJoinType { get; set; }
        string ParentProperty { get; set; }
        string ChildProperty { get; set; }
    }
}
