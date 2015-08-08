using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using TightlyCurly.Com.Common.Data.Builders;
using TightlyCurly.Com.DataAccess.Builders;
using TightlyCurly.Com.Framework;
using TightlyCurly.Com.Framework.Attributes;
using TightlyCurly.Com.Framework.Extensions;
using TightlyCurly.Com.Framework.Helpers;
using TightlyCurly.Com.Tests.Common;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Builders.ReflectionBasedDataReaderBuilderTests
{
    [TestClass]
    public class TheBuildMethod : MoqTestBase<ReflectionBasedDataReaderBuilder>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfDataSourceIsNull()
        {
            TestRunner
                .ExecuteTest(() =>
                    {
                        var exception = AssertException<ArgumentNullException>(
                            () => ItemUnderTest.Build<object>(null));

                        AssertString("dataSource", exception.ParamName);
                    });
        }

        [TestMethod]
        public void WillPopulateFields()
        {
            MockDataReader reader = null;
            TestClassWithFields expected = null;
            
            TestRunner
                .DoCustomSetup(() =>
                {
                    expected = ObjectCreator.CreateNew<TestClassWithFields>();

                    reader = new MockDataReader(new DataContainer(1, new[]
                        {
                            new ColumnInfo
                                {
                                    ColumnName = "Foo",
                                    Values = new object[] {expected.Foo}
                                },
                            new ColumnInfo
                                {
                                    ColumnName = "Bar",
                                    Values = new object[] {expected.Bar}
                                }
                        }));

                    reader.Read();
                })
                .ExecuteTest(() =>
                {
                    var actual = ItemUnderTest.Build<TestClassWithFields>(reader);

                    AssertObject(expected, actual);
                });
        }

        [TestMethod]
        public void WillPopulateEnumFields()
        {
            MockDataReader reader = null;
            EnumClassWithFields expected = null;

            TestRunner
                .DoCustomSetup(() =>
                {
                    var value = MyEnum.Hal;

                    expected = ObjectCreator.CreateNew<EnumClassWithFields>(new Dictionary<string, object>
                        {
                            {"TestField", value}
                        });

                    reader = new MockDataReader(new DataContainer(1, new[]
                        {
                            new ColumnInfo
                                {
                                    ColumnName = "MyEnumValue",
                                    Values = new object[] {(int)value}
                                }
                        }));

                    Mocks.Get<Mock<IEnumParser>>("enumParser")
                        .Setup(x => x.Parse(It.Is<Type>(t => t == typeof(MyEnum)), ((int)value).ToString()))
                        .Returns(value);

                    reader.Read();
                })
                .ExecuteTest(() =>
                {
                    var actual = ItemUnderTest.Build<EnumClassWithFields>(reader);

                    AssertEnum(expected.TestField, actual.TestField);
                });
        }

        [TestMethod]
        public void WillPopulateAndEvaluateFieldTest()
        {
            LoaderTestClass expected = null;
            MockDataReader reader = null;
            string value = null;

            TestRunner
                .DoCustomSetup(() =>
                {
                    expected = ObjectCreator.CreateNew<LoaderTestClass>();
                    value = DataGenerator.GenerateString();

                    reader = new MockDataReader(new DataContainer(1, new[]
                        {
                            new ColumnInfo
                                {
                                    ColumnName = "MyValue",
                                    Values = new object[] {value}
                                },
                            new ColumnInfo
                                {
                                    ColumnName = "IntValue",
                                    Values = new object[] {DataGenerator.GenerateInteger()}
                                }
                        }));

                    Mocks.Get<Mock<ILoaderDelegateFactory>>("delegateFactory")
                        .Setup(x => x.GetLoaderDelegate("MyFieldDelegate"))
                        .Returns(TestFieldMethod);

                    Mocks.Get<Mock<ILoaderDelegateFactory>>("delegateFactory")
                        .Setup(x => x.GetLoaderDelegate("MyPropertyDelegate"))
                        .Returns(e => DataGenerator.GenerateString());

                    reader.Read();
                })
               .ExecuteTest(() =>
                {
                    throw new NotImplementedException();
                    //var actual = ItemUnderTest.Build<LoaderTestClass>(reader);

                    //AssertString(value.FormatString("{0} returned"), actual.FieldTest.Value);
                });
        }

        [TestMethod]
        public void WillPopulateAndEvaluatePropertyTest()
        {
            throw new NotImplementedException();
            //MockDataReader reader = null;
            //var value = 0;

            //TestRunner
            //    .DoCustomSetup(() =>
            //    {
            //        var expected = ObjectCreator.CreateNew<LoaderTestClass>();
            //        value = expected.IntValue;

            //        Mocks.Get<Mock<ILoaderDelegateFactory>>("delegateFactory")
            //            .Setup(x => x.GetLoaderDelegate("MyFieldDelegate"))
            //            .Returns(e => DataGenerator.GenerateString());

            //        Mocks.Get<Mock<ILoaderDelegateFactory>>("delegateFactory")
            //            .Setup(x => x.GetLoaderDelegate("MyPropertyDelegate"))
            //            .Returns(TestFieldMethod);

            //        reader = new MockDataReader(new DataContainer(1, new[]
            //                {
            //                    new ColumnInfo
            //                        {
            //                            ColumnName = "MyValue",
            //                            Values = new object[] {value}
            //                        },
            //                    new ColumnInfo
            //                        {
            //                            ColumnName = "IntValue",
            //                            Values = new object[] {value}
            //                        }
            //                }));

            //        reader.Read();
            //    })
            //.ExecuteTest(() =>
            //{
            //    throw new NotImplementedException();
            //    //var actual = ItemUnderTest.Build<LoaderTestClass>(reader);

            //    //AssertString(value.ToString().FormatString("{0} returned"), actual.PropertyTest.Value);
            //});
        }

        private class TestClassWithFields
        {
            [FieldMapping("Foo")]
            public string Foo { get; set; }

            [FieldMapping("Bar")]
            public string Bar { get; set; }
        }

        private class EnumClassWithFields
        {
            [Enum(typeof(MyEnum), typeof(int), "MyEnumValue")]
            public MyEnum TestField { get; set; }
        }

        private class LoaderTestClass
        {
            //public LoaderTestClass()
            //{
            //    FieldTest = new Loadable<string>();
            //    PropertyTest = new Loadable<string>();
            //}

            //[FieldMapping("IntValue")]
            //public int IntValue { get; set; }

            //[LoaderDelegateKey("MyFieldDelegate")]
            //[FieldParameter("MyValue", typeof(String))]
            //public Loadable<string> FieldTest { get; set; }

            //[LoaderDelegateKey("MyPropertyDelegate")]
            //[PropertyParameter("IntValue")]
            //public Loadable<string> PropertyTest { get; set; }
        }

        private enum MyEnum
        {
            // ReSharper disable UnusedMember.Local
            Hello,
            MyName,
            Is,
            // ReSharper restore UnusedMember.Local
            Hal
        }

        private object TestFieldMethod(object[] value)
        {
            return value.First().ToString().FormatString("{0} returned");
        }
    }
}
