#pragma checksum "D:\Programs\Film Share\Film Share\Views\Search\Components\Actors\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7efa2b90459fe10e1c9e60652ef2ac12c5957f8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Components_Actors_Default), @"mvc.1.0.view", @"/Views/Search/Components/Actors/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Components/Actors/Default.cshtml", typeof(AspNetCore.Views_Search_Components_Actors_Default))]
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
#line 1 "D:\Programs\Film Share\Film Share\Views\_ViewImports.cshtml"
using Film_Share;

#line default
#line hidden
#line 2 "D:\Programs\Film Share\Film Share\Views\_ViewImports.cshtml"
using Film_Share.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7efa2b90459fe10e1c9e60652ef2ac12c5957f8e", @"/Views/Search/Components/Actors/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643f8e1974d42f1f7e109d7c60e3318b5107dc99", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Components_Actors_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FilmShare.ViewModels.ActorModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 29, true);
            WriteLiteral("\r\n<div id=\"usersContainer\">\r\n");
            EndContext();
#line 4 "D:\Programs\Film Share\Film Share\Views\Search\Components\Actors\Default.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(110, 45, true);
            WriteLiteral("        <label>No actors were found</label>\r\n");
            EndContext();
#line 7 "D:\Programs\Film Share\Film Share\Views\Search\Components\Actors\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(162, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 8 "D:\Programs\Film Share\Film Share\Views\Search\Components\Actors\Default.cshtml"
     foreach (var actor in Model)
    {

#line default
#line hidden
            BeginContext(204, 153, true);
            WriteLiteral("        <div class=\"smallProfileInfo\">\r\n            <div class=\"leftProfile\">\r\n                <div class=\"smallAvatarUserBox\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 357, "", 378, 1);
#line 13 "D:\Programs\Film Share\Film Share\Views\Search\Components\Actors\Default.cshtml"
WriteAttributeValue("", 362, actor.PhotoPath, 362, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(378, 162, true);
            WriteLiteral(" style=\'height: 100%; width: 100%; object-fit: contain\'>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <a><b>");
            EndContext();
            BeginContext(541, 10, false);
#line 17 "D:\Programs\Film Share\Film Share\Views\Search\Components\Actors\Default.cshtml"
                 Write(actor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(551, 29, true);
            WriteLiteral("</b></a>\r\n                <p>");
            EndContext();
            BeginContext(581, 37, false);
#line 18 "D:\Programs\Film Share\Film Share\Views\Search\Components\Actors\Default.cshtml"
              Write(actor.DateOfBirth.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(618, 42, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 21 "D:\Programs\Film Share\Film Share\Views\Search\Components\Actors\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(667, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FilmShare.ViewModels.ActorModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
