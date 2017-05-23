# Introduction

A library of tools for working with [Umbraco Ditto](http://umbraco-ditto.readthedocs.io/en/latest/).
It primarily contains a set of Ditto processors used to decorate classes and properties and assist with Ditto mapping operations.

Refer to the [generated documentation](docs/generated.md) for more details.

# Installation

Install with NuGet. Search for "Rhythm.Umbraco.Ditto".

# Overview

## Ditto Processors

Here are the available Ditto processors:

* **CurrentRequestPageAttribute** Returns the page for the current web request. Returns `IPublishedContent`.
* **DittoFirstItemAttribute** Returns the first item from a collection of items.
* **NearestAncestorAttribute** Returns the nearest ancestor of the supplied node that meets the specified criteria. Returns `IPublishedContent`.
* **ParseJsonPickedNodesAttribute** Parses JSON containing picked content node ID's. Assumes a string of this format: `["1", "2", "3"]`. Returns `IEnumerable<string>`.
* **ReplaceYearAttribute** Replaces "{year}" with the current year in a string. Returns `string`.
* **SanitizeForCssAttribute** Sanitizes a string so it can be used as a CSS class. Returns `string`.

The following code sample shows how to use both `ParseJsonPickedNodesAttribute` and `DittoFirstItemAttribute`:

```c#
namespace Sample
{
    using Our.Umbraco.Ditto;
    using Rhythm.Umbraco.Ditto.Processors;
    public class PageModel
    {
        // First, get the value of the "relatedPages" property.
        [UmbracoProperty("relatedPages", Order = 0)]
        // Next, convert that JSON into a collection of strings.
        [ParseJsonPickedNodes(Order = 1)]
        // Finally, extract the first string out of the collection of strings.
        [DittoFirstItem(Order = 2)]
        public string FirstPage { get; set; }
    }
}
```

Note that by convention the "Attribute" suffix is omitted when the attribute is used.

# Maintainers

To create a new release to NuGet, see the [NuGet documentation](docs/nuget.md).