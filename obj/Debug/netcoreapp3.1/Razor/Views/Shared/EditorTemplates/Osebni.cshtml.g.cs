#pragma checksum "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d77cbd80c7b73ad867aaf53fa7687dd12ae27ebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Osebni), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Osebni.cshtml")]
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
#line 1 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\_ViewImports.cshtml"
using EVloga;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\_ViewImports.cshtml"
using EVloga.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d77cbd80c7b73ad867aaf53fa7687dd12ae27ebd", @"/Views/Shared/EditorTemplates/Osebni.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb88d72dd7b69dae9359ef9c68b648c948b83bc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Osebni : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OsebniPodatki>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"form-group\">\r\n    ");
#nullable restore
#line 4 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.LabelFor(m => m.Ime, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 5 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.EditorFor(m => m.Ime, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"form-group\">\r\n    ");
#nullable restore
#line 8 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.LabelFor(m => m.Priimek, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.EditorFor(m => m.Priimek, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"form-group\">\r\n    ");
#nullable restore
#line 12 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.LabelFor(m => m.RojDan, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.EditorFor(m => m.RojDan, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"form-group\">\r\n    ");
#nullable restore
#line 16 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.LabelFor(m => m.KrajRojstva, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.EditorFor(m => m.KrajRojstva, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"form-group\">\r\n    ");
#nullable restore
#line 20 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.LabelFor(m => m.EMSO, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 21 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.EditorFor(m => m.EMSO, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"form-group\">\r\n    ");
#nullable restore
#line 24 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.LabelFor(m => m.Davcna, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 25 "C:\Users\Pero\Desktop\ForDesktopPc\UIKT GDPR\EVloga\Views\Shared\EditorTemplates\Osebni.cshtml"
Write(Html.EditorFor(m => m.Davcna, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div> \r\n<div class=\"form-group\">\r\n    <button type=\"submit\" class=\"btn btn-dark btn-block\">naprej</button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OsebniPodatki> Html { get; private set; }
    }
}
#pragma warning restore 1591
