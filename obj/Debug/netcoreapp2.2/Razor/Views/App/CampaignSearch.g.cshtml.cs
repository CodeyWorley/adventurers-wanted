#pragma checksum "C:\Users\Codey\Projects\dotnet\AdventurersWanted\AdventurersWanted\Views\App\CampaignSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7fb0d18aaff04f301d750f5fa0e2c4a9c21ba4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_CampaignSearch), @"mvc.1.0.view", @"/Views/App/CampaignSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/CampaignSearch.cshtml", typeof(AspNetCore.Views_App_CampaignSearch))]
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
#line 1 "C:\Users\Codey\Projects\dotnet\AdventurersWanted\AdventurersWanted\Views\_ViewImports.cshtml"
using AdventurersWanted.Controllers;

#line default
#line hidden
#line 2 "C:\Users\Codey\Projects\dotnet\AdventurersWanted\AdventurersWanted\Views\_ViewImports.cshtml"
using AdventurersWanted.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7fb0d18aaff04f301d750f5fa0e2c4a9c21ba4e", @"/Views/App/CampaignSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6d6a936ba8b8e952c7748b843b865e21a6fe90", @"/Views/_ViewImports.cshtml")]
    public class Views_App_CampaignSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Campaign>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 21, true);
            WriteLiteral("<h1>Working</h1>\r\n<p>");
            EndContext();
            BeginContext(52, 13, false);
#line 3 "C:\Users\Codey\Projects\dotnet\AdventurersWanted\AdventurersWanted\Views\App\CampaignSearch.cshtml"
Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(65, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Campaign>> Html { get; private set; }
    }
}
#pragma warning restore 1591
