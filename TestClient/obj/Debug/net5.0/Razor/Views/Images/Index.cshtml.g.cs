#pragma checksum "/Users/shannon/Desktop/EPICODUS/C#/TestClient.Solution/TestClient/Views/Images/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a808b25a12cd16c046fd0e2b8cebc4babf6c8286"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Images_Index), @"mvc.1.0.view", @"/Views/Images/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/shannon/Desktop/EPICODUS/C#/TestClient.Solution/TestClient/Views/_ViewImports.cshtml"
using TestClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/shannon/Desktop/EPICODUS/C#/TestClient.Solution/TestClient/Views/Images/Index.cshtml"
using TestClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shannon/Desktop/EPICODUS/C#/TestClient.Solution/TestClient/Views/Images/Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a808b25a12cd16c046fd0e2b8cebc4babf6c8286", @"/Views/Images/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb39e1c2a03ff1e904e834748a67bb717054a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Images_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TestClient.Models.Image>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/shannon/Desktop/EPICODUS/C#/TestClient.Solution/TestClient/Views/Images/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>There are no images yet.</p>\n");
#nullable restore
#line 8 "/Users/shannon/Desktop/EPICODUS/C#/TestClient.Solution/TestClient/Views/Images/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "/Users/shannon/Desktop/EPICODUS/C#/TestClient.Solution/TestClient/Views/Images/Index.cshtml"
 foreach (Image image in Model)
{
  var imgBase64 = Convert.ToBase64String(image.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <img");
            BeginWriteAttribute("src", " src=\"", 233, "\"", 272, 2);
            WriteAttributeValue("", 239, "data:image/jpg;base64,", 239, 22, true);
#nullable restore
#line 13 "/Users/shannon/Desktop/EPICODUS/C#/TestClient.Solution/TestClient/Views/Images/Index.cshtml"
WriteAttributeValue(" ", 261, imgBase64, 262, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n  <br />\n");
#nullable restore
#line 15 "/Users/shannon/Desktop/EPICODUS/C#/TestClient.Solution/TestClient/Views/Images/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TestClient.Models.Image>> Html { get; private set; }
    }
}
#pragma warning restore 1591