#pragma checksum "C:\Users\David Robles\source\repos\URLShortener\URLShortener\Views\BlueBin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da108de977094ae529ccc96514f1db8fe10de65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlueBin_Index), @"mvc.1.0.view", @"/Views/BlueBin/Index.cshtml")]
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
#line 1 "C:\Users\David Robles\source\repos\URLShortener\URLShortener\Views\_ViewImports.cshtml"
using URLShortener;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\David Robles\source\repos\URLShortener\URLShortener\Views\_ViewImports.cshtml"
using URLShortener.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da108de977094ae529ccc96514f1db8fe10de65", @"/Views/BlueBin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67dce9addd7d1c106762b42865542c1f918beccb", @"/Views/_ViewImports.cshtml")]
    public class Views_BlueBin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<URLShortener.Models.Url>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\David Robles\source\repos\URLShortener\URLShortener\Views\BlueBin\Index.cshtml"
Write(Model.UrlShortened);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<URLShortener.Models.Url> Html { get; private set; }
    }
}
#pragma warning restore 1591
