#pragma checksum "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7c61fa7c1d04c71380f1748e956e12225923a2a350241fd5bc71f7e88239f3db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Characters_Details), @"mvc.1.0.view", @"/Views/Characters/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\_ViewImports.cshtml"
using Lab5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\_ViewImports.cshtml"
using Lab5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7c61fa7c1d04c71380f1748e956e12225923a2a350241fd5bc71f7e88239f3db", @"/Views/Characters/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"23295078877b54a164ae153d449b062b440d1f197ce87996ef2a85cf82ce5a07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Characters_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab5.Models.Character>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Character</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <!--DISPLAY CHARACTER INFO-->\r\n        <dt class = \"col-sm-10\" >\r\n            ");
#nullable restore
#line 16 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.LabelFor(model => model.name, "Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.LabelFor(model => model.jobName, "Job"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.jobName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.LabelFor(model => model.role, "Role"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.LabelFor(model => model.maxHP, "Max Hit Points"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.maxHP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.LabelFor(model => model.currentHP, "Current Hit Points"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.currentHP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.LabelFor(model => model.maxAP, "Max Action Points"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.maxAP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.LabelFor(model => model.currentAP, "Current Action Points"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.currentAP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.LabelFor(model => model.currentLevel, "Current Level"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.currentLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.LabelFor(model => model.currentExp, "Current Experience Points"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.currentExp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.LabelFor(model => model.expToNextLevel, "Experience Points Needed for Next Level"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.expToNextLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"flex-column\"></dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c61fa7c1d04c71380f1748e956e12225923a2a350241fd5bc71f7e88239f3db10791", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Characters\Details.cshtml"
                           WriteLiteral(Model.characterID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c61fa7c1d04c71380f1748e956e12225923a2a350241fd5bc71f7e88239f3db12963", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab5.Models.Character> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
