using System.Runtime.Serialization;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    [DataContract]
    public class JoinMapping : IJoinMapping
    {
        [DataMember(Name = "joinType")]
        public JoinType JoinType { get; set; }

        [DataMember(Name = "leftKey")]
        public string LeftKey { get; set; }

        [DataMember(Name = "rightKey")]
        public string RightKey { get; set; }

        [DataMember(Name = "joinTable", IsRequired = false)]
        public string JoinTable { get; set; }

        [DataMember(Name = "joinTableLeftKey", IsRequired = false)]
        public string JoinTableLeftKey { get; set; }

        [DataMember(Name = "joinTableRightKey", IsRequired = false)]
        public string JoinTableRightKey { get; set; }

        [DataMember(Name = "joinTableJoinType", IsRequired = false)]
        public string JoinTableJoinType { get; set; }

        [DataMember(Name = "parentProperty")]
        public string ParentProperty { get; set; }

        [DataMember(Name = "childProperty")]
        public string ChildProperty { get; set; }
    }
}