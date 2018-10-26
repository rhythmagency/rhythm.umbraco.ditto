namespace Rhythm.Umbraco.Ditto.Processors
{

    // Namespaces.
    using Our.Umbraco.Ditto;
    using Rhythm.Core;
    using System;

    /// <summary>
    /// Converts an IEnumerable collection into a list, which avoids any deferred
    /// excution side effects of deferred execution.
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    public class UndeferCollectionAttribute : UmbracoPropertyAttribute
    {

        #region Methods

        /// <summary>
        /// Converts the supplied IEnumerable to a list.
        /// </summary>
        /// <returns>
        /// The list.
        /// </returns>
        public override object ProcessValue()
        {
            if (this.Value == null)
            {
                return null;
            }
            var list = CollectionExtensionMethods.AsList(this.Value as dynamic);
            return list;
        }

        #endregion

    }

}