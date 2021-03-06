#pragma checksum "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1ce99aa595ba1b55741ec213e1bf2991238f01a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetFavorites), @"mvc.1.0.view", @"/Views/Customer/GetFavorites.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\_ViewImports.cshtml"
using MovieCruiserApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\_ViewImports.cshtml"
using MovieCruiserApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1ce99aa595ba1b55741ec213e1bf2991238f01a", @"/Views/Customer/GetFavorites.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4282fe6601f6b11bae7662348653e592d141846", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_GetFavorites : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieCruiserApp.Models.MovieItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
  
    ViewData["Title"] = "GetFavorites";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetFavorites</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 15 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayNameFor(model => model.BoxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayNameFor(model => model.HasTeaser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfLaunch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayNameFor(model => model.GenreId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayFor(modelItem => item.BoxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasTeaser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfLaunch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 55 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
                   List<Genre> list = ViewBag.Genres;

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 56 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.DisplayFor(modelItem => list.FirstOrDefault(g => g.Id == item.GenreId).Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.ActionLink("Buy Tickets", "BuyTickets", new {  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
           Write(Html.ActionLink("Remove from Favorites", "Remove", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\GetFavorites.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieCruiserApp.Models.MovieItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
