﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Moq;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Extensions;
using TightlyCurly.Com.Tests.Common.Helpers;

namespace TightlyCurly.Com.Tests.Common.Base
{
    public abstract class MockTestBase<TItemUnderTest> : TestBase where TItemUnderTest : class
    {
        protected TItemUnderTest ItemUnderTest { get; set; }
        protected PropertyBag Mocks { get; set; }

        protected MockTestBase(IAssertAdapter assertAdapter)
            : base(new RandomDataGenerator(), new ReflectionBasedObjectCreator(), assertAdapter, 
            new SurrogateAsserter(assertAdapter))
        {
        }

        protected MockTestBase(IDataGenerator dataGenerator, IAssertAdapter assertAdapter)
            : base(dataGenerator, new ReflectionBasedObjectCreator(), assertAdapter, 
            new SurrogateAsserter(assertAdapter))
        {
        }

        protected MockTestBase(IDataGenerator dataGenerator, IObjectCreator objectCreator, 
            IAssertAdapter assertAdapter)
            : base(dataGenerator, objectCreator, assertAdapter)
        {
        }

        protected MockTestBase(IObjectCreator objectCreator, IAssertAdapter assertAdapter)
            : base(new RandomDataGenerator(), objectCreator, assertAdapter, 
            new SurrogateAsserter(assertAdapter))
        {
        }

        public override void Setup()
        {
            base.Setup();

            Mocks = new PropertyBag();
            BuildItemUnderTest();
        }

        public override void CleanUp()
        {
            base.CleanUp();

            ItemUnderTest = null;
            Mocks = null;
        }

        private void BuildItemUnderTest()
        {
            var type = typeof(TItemUnderTest);

            if (!type.GetConstructors(BindingFlags.Instance | BindingFlags.Public)
                .Where(c => c.GetParameters().IsNullOrEmpty()).IsNullOrEmpty())
            {
                CreateInstanceWithConstructorNoParameters();
            }
            else
            {
                CreateInstanceWithConstructorParameters(type);
            }
        }

        private void CreateInstanceWithConstructorNoParameters()
        {
            ItemUnderTest = (TItemUnderTest)Activator.CreateInstance(typeof(TItemUnderTest), null);
        }

        private void CreateInstanceWithConstructorParameters(Type type)
        {
            var values = new List<object>();

            var constructor = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public)
                                  .ToSafeList().First(c => !c.GetParameters().IsNullOrEmpty());

            foreach (var parameter in constructor.GetParameters())
            {
                if (Mocks.HasValue(parameter.Name))
                {
                    continue;
                }

                Type parameterType = parameter.ParameterType;
                object value = null;

                if (parameter.ParameterType == typeof(string))
                {
                    value = DataGenerator.GenerateString();
                }
                else
                {
                    parameterType = typeof(Mock<>).MakeGenericType(parameter.ParameterType);

                    var mock = Convert.ChangeType(Activator.CreateInstance(parameterType,
                                                                           null), parameterType);

					var method = Mocks.GetType().GetMethod("Add");
					var genericMethod = method.MakeGenericMethod(parameterType);

					genericMethod.Invoke(Mocks, new object[] { parameter.Name, mock });

                    value = GetObjectFromMock(mock, parameter.ParameterType);
                }

                values.Add(value);
            }

            ItemUnderTest = (TItemUnderTest)Activator.CreateInstance(typeof(TItemUnderTest), values.ToArray());
        }
    }
}