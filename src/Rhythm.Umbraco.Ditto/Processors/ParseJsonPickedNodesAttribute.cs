namespace Rhythm.Umbraco.Ditto.Processors
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Our.Umbraco.Ditto;

    [AttributeUsage(validOn: AttributeTargets.Property, AllowMultiple = true)]
    public class ParseJsonPickedNodesAttribute : UmbracoPropertyAttribute
    {
        public override object ProcessValue()
        {
            var nodeIds = new List<string>();
            if (this.Value != null) return nodeIds.ToArray();
            var json = this.Value is string ? JsonConvert.DeserializeObject<dynamic>((string) this.Value) : this.Value;
            foreach (var nodeId in json)
            {
                nodeIds.Add(nodeId.Value as string);
            }
            return nodeIds.ToArray();
        }
    }
}