namespace Rhythm.Umbraco.Ditto.Processors
{

    // Namespaces.
    using Newtonsoft.Json;
    using Our.Umbraco.Ditto;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parses JSON containing picked content node ID's.
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Property, AllowMultiple = true)]
    public class ParseJsonPickedNodesAttribute : UmbracoPropertyAttribute
    {

        #region Methods

        /// <summary>
        /// Returns a collection of node ID's (each being a string representation of an integer).
        /// </summary>
        /// <returns>
        /// The collection of node ID's.
        /// </returns>
        public override object ProcessValue()
        {

            // Validate input.
            if (Value == null)
            {
                return Enumerable.Empty<string>();
            }

            // Deserialize JSON.
            var nodeIds = new List<string>();
            var json = Value is string
                ? JsonConvert.DeserializeObject<dynamic>(Value as string)
                : Value;

            // Convert to list of strings, and return.
            foreach (var nodeId in json)
            {
                nodeIds.Add(nodeId.Value as string);
            }
            return nodeIds;

        }

        #endregion

    }

}