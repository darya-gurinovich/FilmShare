#pragma checksum "D:\Programs\Film Share\Film Share\Views\Admin\Components\Users\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd7443a3899b10c99a3a5aa48126497bf834b5c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Components_Users_Default), @"mvc.1.0.view", @"/Views/Admin/Components/Users/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Components/Users/Default.cshtml", typeof(AspNetCore.Views_Admin_Components_Users_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd7443a3899b10c99a3a5aa48126497bf834b5c9", @"/Views/Admin/Components/Users/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643f8e1974d42f1f7e109d7c60e3318b5107dc99", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Components_Users_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FilmShare.ViewModels.ProfileModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 29, true);
            WriteLiteral("\r\n<div id=\"usersContainer\">\r\n");
            EndContext();
#line 4 "D:\Programs\Film Share\Film Share\Views\Admin\Components\Users\Default.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(104, 40, true);
            WriteLiteral("    <label>No users were found</label>\r\n");
            EndContext();
#line 7 "D:\Programs\Film Share\Film Share\Views\Admin\Components\Users\Default.cshtml"
}

#line default
#line hidden
#line 8 "D:\Programs\Film Share\Film Share\Views\Admin\Components\Users\Default.cshtml"
 foreach (var profile in Model)
{

#line default
#line hidden
            BeginContext(183, 137, true);
            WriteLiteral("    <div class=\"smallProfileInfo\">\r\n        <div class=\"leftProfile\">\r\n            <div class=\"smallAvatarUserBox\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 320, "", 343, 1);
#line 13 "D:\Programs\Film Share\Film Share\Views\Admin\Components\Users\Default.cshtml"
WriteAttributeValue("", 325, profile.PhotoPath, 325, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(343, 146, true);
            WriteLiteral(" style=\'height: 100%; width: 100%; object-fit: contain\'>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <a><b>");
            EndContext();
            BeginContext(490, 12, false);
#line 17 "D:\Programs\Film Share\Film Share\Views\Admin\Components\Users\Default.cshtml"
             Write(profile.Name);

#line default
#line hidden
            EndContext();
            BeginContext(502, 25, true);
            WriteLiteral("</b></a>\r\n            <p>");
            EndContext();
            BeginContext(528, 39, false);
#line 18 "D:\Programs\Film Share\Film Share\Views\Admin\Components\Users\Default.cshtml"
          Write(profile.DateOfBirth.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(567, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(589, 13, false);
#line 19 "D:\Programs\Film Share\Film Share\Views\Admin\Components\Users\Default.cshtml"
          Write(profile.Email);

#line default
#line hidden
            EndContext();
            BeginContext(602, 34, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 22 "D:\Programs\Film Share\Film Share\Views\Admin\Components\Users\Default.cshtml"
}

#line default
#line hidden
            BeginContext(639, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FilmShare.ViewModels.ProfileModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
