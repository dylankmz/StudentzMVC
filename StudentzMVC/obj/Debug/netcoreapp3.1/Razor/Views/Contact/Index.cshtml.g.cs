#pragma checksum "\\Mac\Home\Documents\NETFrameworks\StudentzMVC\StudentzMVC\StudentzMVC\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3308e3e146436797c7800c24430d6afd683f40a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "\\Mac\Home\Documents\NETFrameworks\StudentzMVC\StudentzMVC\StudentzMVC\Views\_ViewImports.cshtml"
using StudentzMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Documents\NETFrameworks\StudentzMVC\StudentzMVC\StudentzMVC\Views\_ViewImports.cshtml"
using StudentzMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3308e3e146436797c7800c24430d6afd683f40a4", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0875d06b07c9c9d30ce4c471af97720c9e94e2e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "\\Mac\Home\Documents\NETFrameworks\StudentzMVC\StudentzMVC\StudentzMVC\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Contact</h1>\r\n<br />\r\n<h2>");
#nullable restore
#line 9 "\\Mac\Home\Documents\NETFrameworks\StudentzMVC\StudentzMVC\StudentzMVC\Views\Contact\Index.cshtml"
Write(localizer["Mapview"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<br />
<img width=""600"" style=""margin-bottom:1em"" src=""https://maps.googleapis.com/maps/api/staticmap?center=Nijverheidskaai+170&zoom=15&scale=false&size=600x300&maptype=roadmap&key=AIzaSyDG8nl6Suu8KN5gho_s_avBoZiqS-sT1wo&format=png&visual_refresh=true"" alt=""Google Map of Nijverheidskaai 170"">

<h3>");
#nullable restore
#line 13 "\\Mac\Home\Documents\NETFrameworks\StudentzMVC\StudentzMVC\StudentzMVC\Views\Contact\Index.cshtml"
Write(localizer["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n<address>");
#nullable restore
#line 15 "\\Mac\Home\Documents\NETFrameworks\StudentzMVC\StudentzMVC\StudentzMVC\Views\Contact\Index.cshtml"
    Write(localizer["AddressStreet"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</address>\r\n<br />\r\n<h3>");
#nullable restore
#line 17 "\\Mac\Home\Documents\NETFrameworks\StudentzMVC\StudentzMVC\StudentzMVC\Views\Contact\Index.cshtml"
Write(localizer["Phone"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n<a href=\"tel:025233737\">");
#nullable restore
#line 19 "\\Mac\Home\Documents\NETFrameworks\StudentzMVC\StudentzMVC\StudentzMVC\Views\Contact\Index.cshtml"
                   Write(localizer["ContactUs"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 025233737</a> \r\n  ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
