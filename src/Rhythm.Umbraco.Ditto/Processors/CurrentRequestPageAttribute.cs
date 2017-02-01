namespace Rhythm.Umbraco.Ditto.Processors
{

    // Namespaces.
    using global::Umbraco.Web;
    using Our.Umbraco.Ditto;
    using System;

    /// <summary>
    /// This processor returns the page for the current web request.
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Property, AllowMultiple = true)]
    public class CurrentRequestPageAttribute : UmbracoPropertyAttribute
    {

        #region Methods

        /// <summary>
        /// Returns the current page.
        /// </summary>
        /// <returns>
        /// The current page.
        /// </returns>
        public override object ProcessValue()
        {
            return UmbracoContext.Current?.PublishedContentRequest?.PublishedContent;
        }

        #endregion

    }

}