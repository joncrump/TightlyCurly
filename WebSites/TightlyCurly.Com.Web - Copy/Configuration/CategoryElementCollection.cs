using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace TightlyCurly.Com.Web.Configuration
{
    [ConfigurationCollection(typeof(Category))]
    public class CategoryElementCollection : ConfigurationElementCollection
    {
        #region Properties

        public Category this[int index]
        {
            get
            {
                return (Category)BaseGet(index);
            }
        }

        public Category this[object key]
        {
            get
            {
                return (Category)BaseGet(key);
            }
        }

        #endregion

        #region Methods

        public void Add(Category element)
        {
            BaseAdd(element);
        }

        public void Clear()
        {
            BaseClear();
        }

        public void Remove(Category element)
        {
            BaseRemove(element.CategoryName);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new Category();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((Category)element).CategoryName;
        }

        /// <summary>
        /// Returns whether the element name is valid element of the collection.
        /// </summary>
        /// <param name="elementName">The element name string value.</param>
        /// <returns>The value indicating whether the element name is valid element of the collection.</returns>
        protected override bool IsElementName(string elementName)
        {
            if ((string.IsNullOrEmpty(elementName)) || (elementName != "category"))
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}
