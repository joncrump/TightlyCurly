using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Tests.Common.Helpers.Strategies
{
    public class TypeAsserterStrategy : AsserterStrategyBase<Type>
    {
        public override string Name
        {
            get { return Constants.StrategyNames.LongAsserterStrategy; }
        }

        public override Type Type
        {
            get { return typeof(Type); }
        }

        public TypeAsserterStrategy(IAssertAdapter assertAdapter)
            : base(assertAdapter)
        {
        }
        
        public override void AssertEquality(Type expected, Type actual, IEnumerable<string> propertiesToIgnore = null, 
            IDictionary<string, object> additionalParameters = null, bool recurseProperties = false)
        {
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.IsPrimitive, actual.IsPrimitive);
            Assert.AreEqual(expected.Namespace, actual.Namespace);
        }
    }
}