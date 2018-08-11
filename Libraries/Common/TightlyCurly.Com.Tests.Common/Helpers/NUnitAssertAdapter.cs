using NUnit.Framework;

namespace TightlyCurly.Com.Tests.Common.Helpers
{
    public class NUnitAssertAdapter : IAssertAdapter
    {
        public void AreEqual(object expected, object actual, string message = null)
        {
            Assert.That(actual, Is.EqualTo(expected), message);
        }

        public void IsTrue(bool condition, string message = null)
        {
            Assert.That(condition, Is.True, message);
        }

        public void AreEqual<TItem>(TItem expected, TItem actual, string message = null)
        {
            Assert.That(actual, Is.EqualTo(expected), message);
        }

        public void AreNotEqual<TItem>(TItem expected, TItem actual, string message = null)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message);
        }

        public void IsFalse(bool condition, string message = null)
        {
            Assert.That(condition, Is.False, message);
        }

        public void Inconclusive(string message)
        {
            Assert.Inconclusive(message);
        }

        public void IsNotNull(object value, string message = null)
        {
            Assert.That(value, Is.Not.Null);
        }

        public void IsNull(object value, string message = null)
        {
            Assert.That(value, Is.Null);
        }
    }
}