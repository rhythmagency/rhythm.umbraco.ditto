namespace Rhythm.Umbraco.Ditto.Processors
{

    // Namespaces.
    using Our.Umbraco.Ditto;
    using System;
    using System.Text.RegularExpressions;
    using System.Web;

    /// <summary>
    /// This processor replaces "{year}" with the current year in a string.
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Property, AllowMultiple = true)]
    public class ReplaceYearAttribute : UmbracoPropertyAttribute
    {

        #region Properties

        /// <summary>
        /// Matches "{year}".
        /// </summary>
        private static Regex YearRegex { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Static constructor.
        /// </summary>
        static ReplaceYearAttribute()
        {
            var options = RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline;
            YearRegex = new Regex("{year}", options);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the year in a string.
        /// </summary>
        /// <returns>
        /// The string with the current year.
        /// </returns>
        public override object ProcessValue()
        {
            var stringValue = Value as string ?? (Value as HtmlString)?.ToString();
            return string.IsNullOrWhiteSpace(stringValue)
                ? stringValue
                : YearRegex.Replace(stringValue, DateTime.Now.Year.ToString());
        }

        #endregion

    }

}