#pragma checksum "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59df5b47a41a004ac5e34af0a404d5a6bf040579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Details.cshtml", typeof(AspNetCore.Views_Clients_Details))]
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
#line 1 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\_ViewImports.cshtml"
using SDC_Web;

#line default
#line hidden
#line 2 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\_ViewImports.cshtml"
using SDC_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59df5b47a41a004ac5e34af0a404d5a6bf040579", @"/Views/Clients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8df17492fda0035aed1881beeaea7bb718f24b", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDC_Web.Models.Client>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(75, 133, true);
            WriteLiteral("\r\n    <h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Client</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(209, 45, false);
#line 14 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(254, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(318, 41, false);
#line 17 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(359, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(422, 44, false);
#line 20 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(466, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(530, 40, false);
#line 23 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(570, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(633, 44, false);
#line 26 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(677, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(741, 40, false);
#line 29 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(781, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(844, 43, false);
#line 32 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
            EndContext();
            BeginContext(887, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(951, 39, false);
#line 35 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company));

#line default
#line hidden
            EndContext();
            BeginContext(990, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1053, 41, false);
#line 38 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1158, 37, false);
#line 41 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1258, 43, false);
#line 44 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1365, 39, false);
#line 47 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1467, 40, false);
#line 50 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1571, 36, false);
#line 53 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1670, 44, false);
#line 56 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Province));

#line default
#line hidden
            EndContext();
            BeginContext(1714, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1778, 40, false);
#line 59 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Province));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1881, 46, false);
#line 62 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Postalcode));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1991, 42, false);
#line 65 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Postalcode));

#line default
#line hidden
            EndContext();
            BeginContext(2033, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2096, 41, false);
#line 68 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2137, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2201, 37, false);
#line 71 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2238, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2301, 43, false);
#line 74 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(2344, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2408, 39, false);
#line 77 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(2447, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2510, 43, false);
#line 80 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BizType));

#line default
#line hidden
            EndContext();
            BeginContext(2553, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2617, 39, false);
#line 83 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.BizType));

#line default
#line hidden
            EndContext();
            BeginContext(2656, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2719, 43, false);
#line 86 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BizYear));

#line default
#line hidden
            EndContext();
            BeginContext(2762, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2826, 39, false);
#line 89 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.BizYear));

#line default
#line hidden
            EndContext();
            BeginContext(2865, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2928, 48, false);
#line 92 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Associations));

#line default
#line hidden
            EndContext();
            BeginContext(2976, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3040, 44, false);
#line 95 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Associations));

#line default
#line hidden
            EndContext();
            BeginContext(3084, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3147, 47, false);
#line 98 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Recommender));

#line default
#line hidden
            EndContext();
            BeginContext(3194, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3258, 43, false);
#line 101 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Recommender));

#line default
#line hidden
            EndContext();
            BeginContext(3301, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3364, 39, false);
#line 104 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hst));

#line default
#line hidden
            EndContext();
            BeginContext(3403, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3467, 35, false);
#line 107 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hst));

#line default
#line hidden
            EndContext();
            BeginContext(3502, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3565, 45, false);
#line 110 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Reference));

#line default
#line hidden
            EndContext();
            BeginContext(3610, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3674, 41, false);
#line 113 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Reference));

#line default
#line hidden
            EndContext();
            BeginContext(3715, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3778, 43, false);
#line 116 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mailing));

#line default
#line hidden
            EndContext();
            BeginContext(3821, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3885, 39, false);
#line 119 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mailing));

#line default
#line hidden
            EndContext();
            BeginContext(3924, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3987, 40, false);
#line 122 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Term));

#line default
#line hidden
            EndContext();
            BeginContext(4027, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4091, 36, false);
#line 125 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Term));

#line default
#line hidden
            EndContext();
            BeginContext(4127, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4190, 45, false);
#line 128 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Timestamp));

#line default
#line hidden
            EndContext();
            BeginContext(4235, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4299, 41, false);
#line 131 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Timestamp));

#line default
#line hidden
            EndContext();
            BeginContext(4340, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4403, 44, false);
#line 134 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(4447, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4511, 40, false);
#line 137 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(4551, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(4598, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59df5b47a41a004ac5e34af0a404d5a6bf04057921405", async() => {
                BeginContext(4650, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 142 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Clients\Details.cshtml"
                           WriteLiteral(Model.ClientId);

#line default
#line hidden
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
            EndContext();
            BeginContext(4658, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(4666, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59df5b47a41a004ac5e34af0a404d5a6bf04057923721", async() => {
                BeginContext(4688, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(4704, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDC_Web.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591