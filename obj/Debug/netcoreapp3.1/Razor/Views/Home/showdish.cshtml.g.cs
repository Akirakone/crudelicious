#pragma checksum "C:\Users\Akira\Desktop\C#\crudelicious\Views\Home\showdish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4814e07d966d56f22fb88ef726129d14fa95999"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_showdish), @"mvc.1.0.view", @"/Views/Home/showdish.cshtml")]
namespace MyApp.Namespace.Home
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
#line 1 "C:\Users\Akira\Desktop\C#\crudelicious\Views\Home\showdish.cshtml"
using crudelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4814e07d966d56f22fb88ef726129d14fa95999", @"/Views/Home/showdish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1d1eb37dc6f0d82250bf784d7ea6a0b75ca51c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_showdish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 4 "C:\Users\Akira\Desktop\C#\crudelicious\Views\Home\showdish.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>BY ");
#nullable restore
#line 5 "C:\Users\Akira\Desktop\C#\crudelicious\Views\Home\showdish.cshtml"
  Write(Model.chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n<p>");
#nullable restore
#line 8 "C:\Users\Akira\Desktop\C#\crudelicious\Views\Home\showdish.cshtml"
Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Calories : ");
#nullable restore
#line 9 "C:\Users\Akira\Desktop\C#\crudelicious\Views\Home\showdish.cshtml"
         Write(Model.calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Tastiness : ");
#nullable restore
#line 10 "C:\Users\Akira\Desktop\C#\crudelicious\Views\Home\showdish.cshtml"
          Write(Model.tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 199, "\"", 227, 2);
            WriteAttributeValue("", 206, "/delete/", 206, 8, true);
#nullable restore
#line 13 "C:\Users\Akira\Desktop\C#\crudelicious\Views\Home\showdish.cshtml"
WriteAttributeValue("", 214, Model.dishid, 214, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 266, "\"", 296, 2);
            WriteAttributeValue("", 273, "/editDish/", 273, 10, true);
#nullable restore
#line 14 "C:\Users\Akira\Desktop\C#\crudelicious\Views\Home\showdish.cshtml"
WriteAttributeValue("", 283, Model.dishid, 283, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Edit</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
