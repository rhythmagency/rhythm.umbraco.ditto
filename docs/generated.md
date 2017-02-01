# Rhythm.Umbraco.Ditto

<table>
<tbody>
<tr>
<td><a href="#currentrequestpageattribute">CurrentRequestPageAttribute</a></td>
<td><a href="#dittofirstitemattribute">DittoFirstItemAttribute</a></td>
</tr>
<tr>
<td><a href="#nearestancestorattribute">NearestAncestorAttribute</a></td>
<td><a href="#replaceyearattribute">ReplaceYearAttribute</a></td>
</tr>
<tr>
<td><a href="#sanitizeforcssattribute">SanitizeForCssAttribute</a></td>
</tr>
</tbody>
</table>


## CurrentRequestPageAttribute

This processor returns the page for the current web request.

### ProcessValue

Returns the current page.

#### Returns

The current page.


## DittoFirstItemAttribute

This processor returns the first item from a collection of items.

### ProcessValue

Returns the first item in the collection of items.

#### Returns

The first item in the collection, or null.

#### Remarks

If the collection is empty or invalid, null will be returned.


## NearestAncestorAttribute

This processor returns the nearest ancestor of the supplied node that meets the specified criteria.

### Constructor(System.String)

Default constructor.

### ContentTypeAlias

The content type alias to match when searching for the nearest ancestor.

### ProcessValue

The nearest matching ancestor.

#### Returns

The ancestor, or null.


## ReplaceYearAttribute

This processor replaces "{year}" with the current year in a string.

### #cctor

Static constructor.

### ProcessValue

Returns the year in a string.

#### Returns

The string with the current year.

### YearRegex

Matches "{year}".


## SanitizeForCssAttribute

This processor sanitizes a string so it can be used as a CSS class.

### ProcessValue

Sanitizes the string to be used as a CSS class.

#### Returns

The sanitized string.
