#pragma checksum "/Users/obinnauzozie/Projects/FirstMVCApp/FirstMVCApp/Views/HelloWorld/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c086ed7dbb67a4bffd64b9f99e518382fcdf4f0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_index), @"mvc.1.0.view", @"/Views/HelloWorld/index.cshtml")]
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
#line 1 "/Users/obinnauzozie/Projects/FirstMVCApp/FirstMVCApp/Views/_ViewImports.cshtml"
using FirstMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/obinnauzozie/Projects/FirstMVCApp/FirstMVCApp/Views/_ViewImports.cshtml"
using FirstMVCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c086ed7dbb67a4bffd64b9f99e518382fcdf4f0f", @"/Views/HelloWorld/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c484353cf842f8338eb6a82fb94138801ad636", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HelloWorld_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FirstMVCApp.Models.DogViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>Hello World bro!</h1>\r\n<p>This is the index page of the HelloWorld Controller</p>\r\n\r\n\r\n<ul>\r\n");
#nullable restore
#line 11 "/Users/obinnauzozie/Projects/FirstMVCApp/FirstMVCApp/Views/HelloWorld/index.cshtml"
     foreach(var dog in Model){


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\n            ");
#nullable restore
#line 14 "/Users/obinnauzozie/Projects/FirstMVCApp/FirstMVCApp/Views/HelloWorld/index.cshtml"
       Write(dog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 14 "/Users/obinnauzozie/Projects/FirstMVCApp/FirstMVCApp/Views/HelloWorld/index.cshtml"
                  Write(dog.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\n        </li>\n");
#nullable restore
#line 16 "/Users/obinnauzozie/Projects/FirstMVCApp/FirstMVCApp/Views/HelloWorld/index.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 22 "/Users/obinnauzozie/Projects/FirstMVCApp/FirstMVCApp/Views/HelloWorld/index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FirstMVCApp.Models.DogViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
