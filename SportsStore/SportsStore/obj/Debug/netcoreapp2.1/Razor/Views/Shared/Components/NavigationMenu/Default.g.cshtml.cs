#pragma checksum "C:\Users\Danil\Desktop\ASP.Net Core MVC\SportStore\SportsStore\SportsStore\Views\Shared\Components\NavigationMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b29cc8deae0f9cc70d3c77f86c22a8f589bb8bf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NavigationMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NavigationMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/NavigationMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_NavigationMenu_Default))]
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
#line 1 "C:\Users\Danil\Desktop\ASP.Net Core MVC\SportStore\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#line 2 "C:\Users\Danil\Desktop\ASP.Net Core MVC\SportStore\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29cc8deae0f9cc70d3c77f86c22a8f589bb8bf8", @"/Views/Shared/Components/NavigationMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1f47b9a9d830dbf35109f97624029c37d5cf547", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NavigationMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 130, true);
            WriteLiteral("\r\n<a class=\"btn btn-block btn-secondary\"\r\n   asp-action=\"List\"\r\n   asp-controller=\"Product\"\r\n   asp-route-category=\"\">Home</a>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Danil\Desktop\ASP.Net Core MVC\SportStore\SportsStore\SportsStore\Views\Shared\Components\NavigationMenu\Default.cshtml"
 foreach (string category in Model)
{

#line default
#line hidden
            BeginContext(198, 51, true);
            WriteLiteral("    <a \r\n       class=\"btn btn-block btn-secondary\"");
            EndContext();
            BeginWriteAttribute("asp-route-category", "\r\n       asp-route-category=\"", 249, "\"", 287, 1);
#line 12 "C:\Users\Danil\Desktop\ASP.Net Core MVC\SportStore\SportsStore\SportsStore\Views\Shared\Components\NavigationMenu\Default.cshtml"
WriteAttributeValue("", 278, category, 278, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(288, 35, true);
            WriteLiteral("\r\n       asp-route-productPage=\"1\">");
            EndContext();
            BeginContext(324, 8, false);
#line 13 "C:\Users\Danil\Desktop\ASP.Net Core MVC\SportStore\SportsStore\SportsStore\Views\Shared\Components\NavigationMenu\Default.cshtml"
                            Write(category);

#line default
#line hidden
            EndContext();
            BeginContext(332, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 14 "C:\Users\Danil\Desktop\ASP.Net Core MVC\SportStore\SportsStore\SportsStore\Views\Shared\Components\NavigationMenu\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
