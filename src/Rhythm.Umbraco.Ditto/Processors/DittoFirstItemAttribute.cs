namespace Rhythm.Umbraco.Ditto.Processors
{

    // Namespaces.
    using Our.Umbraco.Ditto;
    using System;
    using System.Collections;

    /// <summary>
    /// This processor returns the first item from a collection of items.
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Property, AllowMultiple = true)]
    public class DittoFirstItemAttribute : UmbracoPropertyAttribute
    {

        #region Methods

        /// <summary>
        /// Returns the first item in the collection of items.
        /// </summary>
        /// <returns>
        /// The first item in the collection, or null.
        /// </returns>
        /// <remarks>
        /// If the collection is empty or invalid, null will be returned.
        /// </remarks>
        public override object ProcessValue()
        {
            var items = this.Value as IEnumerable;
            if (items != null)
            {
                foreach (var item in items)
                {
                    return item;
                }
            }
            return null;
        }

        #endregion

    }

}