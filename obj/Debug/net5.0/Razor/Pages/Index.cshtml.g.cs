#pragma checksum "C:\Users\Vikumsri\Documents\GitHub\notifyappwithchanges\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57a5fd76e24f34488b323f5c8e2c0ff6e41900a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HabitApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace HabitApp.Pages
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
#line 1 "C:\Users\Vikumsri\Documents\GitHub\notifyappwithchanges\Pages\_ViewImports.cshtml"
using HabitApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57a5fd76e24f34488b323f5c8e2c0ff6e41900a8", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d8de3ee89885d71118c8112e0d377848ef63c3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Vikumsri\Documents\GitHub\notifyappwithchanges\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-5 responsive\" style=\"width:100%;height:auto; align-content:center\">\r\n\t<div class=\"card\" style=\"width:50%;height:auto; margin-left:auto; margin-right:auto\">\r\n      <img");
            BeginWriteAttribute("src", " src=\"", 265, "\"", 299, 1);
#nullable restore
#line 9 "C:\Users\Vikumsri\Documents\GitHub\notifyappwithchanges\Pages\Index.cshtml"
WriteAttributeValue("", 271, Model.HabitModel.habitImage, 271, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n      <div class=\"card-body\">\r\n          <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\Vikumsri\Documents\GitHub\notifyappwithchanges\Pages\Index.cshtml"
                            Write(Model.HabitModel.habitTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n          <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\Vikumsri\Documents\GitHub\notifyappwithchanges\Pages\Index.cshtml"
                          Write(Model.HabitModel.habitDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <a href=""#"" class=""btn btn-primary"" style=""margin-left:80px"" onclick=""viewPage()"">See more</a>
      </div>
    </div>
</div>

<script>
    
    
    function viewPage()
    {
        var email = window.localStorage.getItem(""email"")
        if (email == null) {
            window.location.href = ""/login""
        } else {
            window.location.href = ""/viewhabits""
        }
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
