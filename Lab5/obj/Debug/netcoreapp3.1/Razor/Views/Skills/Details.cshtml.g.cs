#pragma checksum "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e5faddfe5b831dc2d9dff313fc05628316c7cdf07128ed99f8ced757acf7fe17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skills_Details), @"mvc.1.0.view", @"/Views/Skills/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e5faddfe5b831dc2d9dff313fc05628316c7cdf07128ed99f8ced757acf7fe17", @"/Views/Skills/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"23295078877b54a164ae153d449b062b440d1f197ce87996ef2a85cf82ce5a07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skills_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab5.Models.Skill>
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
#line 3 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var jobs = ViewData["JobList"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Skill</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <!--DISPLAY SKILL DETAILS-->\r\n        <dt class = \"col-sm-10\">\r\n            Skill Name\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
       Write(Html.DisplayFor(model => model.skillName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            Skill Description\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
       Write(Html.DisplayFor(model => model.skillDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            Job\r\n        </dt>\r\n\r\n        <!--FIND THE JOB ID IN VIEWDATA MATCHING THE CURRENT SKILL\'S JOBID-->\r\n");
#nullable restore
#line 32 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
             foreach (var job in (List<Job>)ViewData["JobList"])
            {
                if (job.JobId == Model.jobId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dd class=\"col-sm-10\">");
#nullable restore
#line 36 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
                                     Write(job.JobName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 36 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
                                                    Write(job.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </dd>\r\n");
#nullable restore
#line 37 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <dt class = \"col-sm-10\">\r\n            Skill Type\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
       Write(Html.DisplayFor(model => model.skillType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            Action Points Cost\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
       Write(Html.DisplayFor(model => model.apCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            Base Power\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
       Write(Html.DisplayFor(model => model.abilityDmg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            Skill Element\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
       Write(Html.DisplayFor(model => model.dmgType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            Critical Hit DMG Multiplier\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
       Write(Html.DisplayFor(model => model.critMultiplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            Level Learned\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 74 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
       Write(Html.DisplayFor(model => model.levelLearned));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5faddfe5b831dc2d9dff313fc05628316c7cdf07128ed99f8ced757acf7fe178719", async() => {
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
#line 79 "C:\GH KFinle\ASP.NET-Character-Creator\Lab5\Views\Skills\Details.cshtml"
                           WriteLiteral(Model.SkillId);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5faddfe5b831dc2d9dff313fc05628316c7cdf07128ed99f8ced757acf7fe1710882", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab5.Models.Skill> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
