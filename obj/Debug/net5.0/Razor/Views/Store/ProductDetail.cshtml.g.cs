#pragma checksum "C:\Users\Aconte\Desktop\bag\angels\angels\Views\Store\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcc26963ba42077d7a92841f867316892e15e44c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_ProductDetail), @"mvc.1.0.view", @"/Views/Store/ProductDetail.cshtml")]
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
#line 1 "C:\Users\Aconte\Desktop\bag\angels\angels\Views\_ViewImports.cshtml"
using angels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aconte\Desktop\bag\angels\angels\Views\_ViewImports.cshtml"
using angels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc26963ba42077d7a92841f867316892e15e44c", @"/Views/Store/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf022c818ecc128373b59553a9178b7d6cb9bba8", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<angels.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"

    <div class=""container mx-auto max-w-4xl py-28 px-8"">

      <div class=""pb-16"">
        <a href=""#"" class=""font-sans text-lg text-white bg-black py-2 px-10 transition ease-in-out duration-150 hover:bg-gray-800"">Go to Store</a>
      </div>
        <div class=""grid grid-cols-1 md:grid-cols-2"">
            <div class=""mb-5 md:mb-0"">
                <img src=""/mgs/one.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 552, "\"", 558, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"py-2 pl-10\">\r\n                  <h1 class=\"font-sans text-2xl md:text-3xl tracking-wide pb-4\">");
#nullable restore
#line 21 "C:\Users\Aconte\Desktop\bag\angels\angels\Views\Store\ProductDetail.cshtml"
                                                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                  <p class=\"font-sans text-xl text-red-500 underline pb-4\">$ ");
#nullable restore
#line 22 "C:\Users\Aconte\Desktop\bag\angels\angels\Views\Store\ProductDetail.cshtml"
                                                                        Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <h1 class=\"flex gap-6 text-xl items-center pb-10\">\r\n                      <span>Available</span>\r\n                      <span class=\"border-2 border-black py-1 px-2\">4</span>\r\n                  </h1>\r\n\r\n                  <div");
            BeginWriteAttribute("class", " class=\"", 1056, "\"", 1064, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                      <h1 class=\"font-sans text-3xl md:text-4xl pb-4\">Product Info</h1>\r\n                      <p class=\"font-sans text-lg tracking-wide leading-8\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\Aconte\Desktop\bag\angels\angels\Views\Store\ProductDetail.cshtml"
                   Write(Model.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n                      </p>\r\n                  </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<angels.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591