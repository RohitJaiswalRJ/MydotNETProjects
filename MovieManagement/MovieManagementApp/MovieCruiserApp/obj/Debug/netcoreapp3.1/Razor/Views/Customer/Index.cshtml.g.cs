#pragma checksum "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "684a85deb62fb465390a7778271b146c8ea059a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684a85deb62fb465390a7778271b146c8ea059a3", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4282fe6601f6b11bae7662348653e592d141846", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieCruiserApp.Models.MovieItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "684a85deb62fb465390a7778271b146c8ea059a33745", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 18 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BoxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HasTeaser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsFavorite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfLaunch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GenreId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          \r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BoxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasTeaser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n");
#nullable restore
#line 56 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
                   
                    List<MovieItem> listm = ViewBag.FavMovies;
                    MovieItem? check = listm.FirstOrDefault(m => m.Id == item.Id);

                    if (check !=null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
#nullable restore
#line 63 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
                           Write(Html.CheckBox("IsFavorite", true,new {@disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                             </td>\r\n");
#nullable restore
#line 65 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
#nullable restore
#line 69 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IsFavorite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 71 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>\r\n                ");
#nullable restore
#line 75 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfLaunch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 81 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
                   List<Genre> list = ViewBag.Genres;

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 82 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => list.FirstOrDefault(g=>g.Id == item.GenreId).Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 85 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
                 if (check == null)
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.ActionLink("Add To Favorites", "AddToFavorites", new { id = item.Id }, new { @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
                                                                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n                ");
#nullable restore
#line 88 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
           Write(Html.ActionLink("Buy Tickets", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 91 "D:\.NET\.NET_Projects\MovieCruiserApp\MovieCruiserApp\Views\Customer\Index.cshtml"
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
