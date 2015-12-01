namespace TightlyCurly.Com.Common.Data
{
    public interface IJoinMapping
    {
        string JoinType { get; set; }
        string LeftKey { get; set; }
        string RightKey { get; set; }
        string JoinTable { get; set; }
        string JoinTableJoinType { get; set; }
        string JoinTableLeftKey { get; set; }
        string JoinTableRightKey { get; set; }
    }
}
