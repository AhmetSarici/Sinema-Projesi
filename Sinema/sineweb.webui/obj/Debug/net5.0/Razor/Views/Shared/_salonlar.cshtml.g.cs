#pragma checksum "C:\Users\ahmet\OneDrive\Masaüstü\B39\Sine\Sinema\sineweb.webui\Views\Shared\_salonlar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb0606af7a4db3b564acc82fc5f96b9018b08e25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__salonlar), @"mvc.1.0.view", @"/Views/Shared/_salonlar.cshtml")]
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
#line 2 "C:\Users\ahmet\OneDrive\Masaüstü\B39\Sine\Sinema\sineweb.webui\_ViewImports.cshtml"
using sineweb.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0606af7a4db3b564acc82fc5f96b9018b08e25", @"/Views/Shared/_salonlar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2def7315d49ae6f8abecbc4cc42bb0a604b800", @"/_ViewImports.cshtml")]
    public class Views_Shared__salonlar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Salon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n <div class=\"list-group\">\r\n");
#nullable restore
#line 4 "C:\Users\ahmet\OneDrive\Masaüstü\B39\Sine\Sinema\sineweb.webui\Views\Shared\_salonlar.cshtml"
     foreach (var salon in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 6 "C:\Users\ahmet\OneDrive\Masaüstü\B39\Sine\Sinema\sineweb.webui\Views\Shared\_salonlar.cshtml"
                                                              Write(salon.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 7 "C:\Users\ahmet\OneDrive\Masaüstü\B39\Sine\Sinema\sineweb.webui\Views\Shared\_salonlar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Salon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
