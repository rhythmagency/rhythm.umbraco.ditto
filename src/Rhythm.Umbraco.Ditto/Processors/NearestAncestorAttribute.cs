namespace Rhythm.Umbraco.Ditto.Processors
{

    // Namespaces.
    using global::Umbraco.Core.Models;
    using global::Umbraco.Web;
    using Our.Umbraco.Ditto;
    using System;

    /// <summary>
    /// This processor returns the nearest ancestor of the supplied node that
    /// meets the specified criteria.
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Property, AllowMultiple = true)]
    public class NearestAncestorAttribute : UmbracoPropertyAttribute
    {

        #region Properties

        /// <summary>
        /// The content type alias to match when searching for the nearest ancestor.
        /// </summary>
        private string ContentTypeAlias { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public NearestAncestorAttribute(string ContentTypeAlias = null) : base()
        {
            this.ContentTypeAlias = ContentTypeAlias;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The nearest matching ancestor.
        /// </summary>
        /// <returns>
        /// The ancestor, or null.
        /// </returns>
        public override object ProcessValue()
        {
            var page = this.Value as IPublishedContent;
            if (page == null)
            {
                return null;
            }
            else
            {
                return page.Ancestor(ContentTypeAlias);
            }
        }

        #endregion

    }

}