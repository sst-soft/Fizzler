# Excessive stripped-down SVG rendering tool for .NET6

## Fork modifications:
This repository is a fork from [svg-net](https://github.com/atifaziz/Fizzler). 
This fork was created, to build a **excessively** stripped down version with only **.NET6** support.
There will be *no* active development on this fork, other than merging from underlying respositories. For more complex implementation, please visit the relevant forks instead.
Only use this fork, if you know what you are doing! You have been warned :-)

# Original Readme.md
<details><summary>Click to open Readme.md</summary>
<p>

# Fizzler: .NET CSS Selector Engine

[![Build Status][win-build-badge]][win-builds]
[![Build Status][nix-build-badge]][nix-builds]
[![NuGet][nuget-badge]][nuget-pkg]
[![MyGet][myget-badge]][edge-pkgs]

Fizzler is a .NET Standard 1.0 library; it is a [W3C Selectors
(Level 3)][w3cs3] parser and generic selector framework over document
hierarchies.

The [default implementation][fizzhap] is based on [HTMLAgilityPack][hap] and
selects from HTML documents. The unit tests are based on the jQuery
selector engine tests.

Contributions are welcome in forms of:

  * Increased selector support
  * Implementation over an HTML-like hierarchical document model
  * Re-factorings
  * Improved tests

## Examples

The following example uses [Fizzler.Systems.HtmlAgilityPack][fizzhap]:

```c#
// Load the document using HTMLAgilityPack as normal
var html = new HtmlDocument();
html.LoadHtml(@"
  <html>
      <head></head>
      <body>
        <div>
          <p class='content'>Fizzler</p>
          <p>CSS Selector Engine</p></div>
      </body>
  </html>");

// Fizzler for HtmlAgilityPack is implemented as the
// QuerySelectorAll extension method on HtmlNode

var document = html.DocumentNode;

// yields: [<p class="content">Fizzler</p>]
document.QuerySelectorAll(".content");

// yields: [<p class="content">Fizzler</p>,<p>CSS Selector Engine</p>]
document.QuerySelectorAll("p");

// yields empty sequence
document.QuerySelectorAll("body>p");

// yields [<p class="content">Fizzler</p>,<p>CSS Selector Engine</p>]
document.QuerySelectorAll("body p");

// yields [<p class="content">Fizzler</p>]
document.QuerySelectorAll("p:first-child");
```


[win-build-badge]: https://img.shields.io/appveyor/ci/raboof/fizzler/master.svg?label=windows
[win-builds]: https://ci.appveyor.com/project/raboof/fizzler
[nix-build-badge]: https://img.shields.io/travis/atifaziz/Fizzler/master.svg?label=linux
[nix-builds]: https://travis-ci.org/atifaziz/Fizzler
[myget-badge]: https://img.shields.io/myget/raboof/vpre/Fizzler.svg?label=myget
[edge-pkgs]: https://www.myget.org/feed/raboof/package/nuget/Fizzler
[nuget-badge]: https://img.shields.io/nuget/v/Fizzler.svg
[nuget-pkg]: https://www.nuget.org/packages/Fizzler

[w3cs3]: https://www.w3.org/TR/selectors-3/
[fizzhap]: http://www.nuget.org/packages/Fizzler.Systems.HtmlAgilityPack/
[hap]: http://html-agility-pack.net/


</p>
</details>