#pragma checksum "D:\Programs\Film Share\Film Share\Views\Search\Components\Films\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f7b53955f13015f8413e59585a928671b292297"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Components_Films_Default), @"mvc.1.0.view", @"/Views/Search/Components/Films/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Components/Films/Default.cshtml", typeof(AspNetCore.Views_Search_Components_Films_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f7b53955f13015f8413e59585a928671b292297", @"/Views/Search/Components/Films/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643f8e1974d42f1f7e109d7c60e3318b5107dc99", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Components_Films_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FilmShare.ViewModels.FilmModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Film", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(45, 29, true);
            WriteLiteral("\r\n<div id=\"usersContainer\">\r\n");
            EndContext();
#line 4 "D:\Programs\Film Share\Film Share\Views\Search\Components\Films\Default.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(109, 44, true);
            WriteLiteral("        <label>No films were found</label>\r\n");
            EndContext();
#line 7 "D:\Programs\Film Share\Film Share\Views\Search\Components\Films\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(160, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 8 "D:\Programs\Film Share\Film Share\Views\Search\Components\Films\Default.cshtml"
     foreach (var film in Model)
    {

#line default
#line hidden
            BeginContext(201, 153, true);
            WriteLiteral("        <div class=\"smallProfileInfo\">\r\n            <div class=\"leftProfile\">\r\n                <div class=\"smallAvatarUserBox\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 354, "", 375, 1);
#line 13 "D:\Programs\Film Share\Film Share\Views\Search\Components\Films\Default.cshtml"
WriteAttributeValue("", 359, film.PosterPath, 359, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(375, 156, true);
            WriteLiteral(" style=\'height: 100%; width: 100%; object-fit: contain\'>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(531, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cee82dda0c794676bc6f10cf0fefdecf", async() => {
                BeginContext(605, 3, true);
                WriteLiteral("<b>");
                EndContext();
                BeginContext(609, 13, false);
#line 17 "D:\Programs\Film Share\Film Share\Views\Search\Components\Films\Default.cshtml"
                                                                                        Write(film.FilmName);

#line default
#line hidden
                EndContext();
                BeginContext(622, 4, true);
                WriteLiteral("</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filmId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "D:\Programs\Film Share\Film Share\Views\Search\Components\Films\Default.cshtml"
                                                                 WriteLiteral(film.FilmId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filmId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filmId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filmId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(630, 21, true);
            WriteLiteral("\r\n                <p>");
            EndContext();
            BeginContext(652, 9, false);
#line 18 "D:\Programs\Film Share\Film Share\Views\Search\Components\Films\Default.cshtml"
              Write(film.Year);

#line default
#line hidden
            EndContext();
            BeginContext(661, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(687, 12, false);
#line 19 "D:\Programs\Film Share\Film Share\Views\Search\Components\Films\Default.cshtml"
              Write(film.Country);

#line default
#line hidden
            EndContext();
            BeginContext(699, 42, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 22 "D:\Programs\Film Share\Film Share\Views\Search\Components\Films\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(748, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FilmShare.ViewModels.FilmModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
