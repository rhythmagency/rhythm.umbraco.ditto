namespace Rhythm.Umbraco.Ditto.Processors
{

    // Namespaces.
    using Our.Umbraco.Ditto;
    using Rhythm.Core;
    using System;

    /// <summary>
    /// This processor sanitizes a string so it can be used as a CSS class.
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Property, AllowMultiple = true)]
    public class SanitizeForCssAttribute : UmbracoPropertyAttribute
    {

        #region Methods

        /// <summary>
        /// Sanitizes the string to be used as a CSS class.
        /// </summary>
        /// <returns>
        /// The sanitized string.
        /// </returns>
        public override object ProcessValue()
        {
            var item = this.Value as string;
            return item.SanitizeForCss();
        }

        #endregion

    }

}