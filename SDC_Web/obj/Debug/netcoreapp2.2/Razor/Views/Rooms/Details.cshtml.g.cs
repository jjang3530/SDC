#pragma checksum "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13b500220a67c809ce1e202a9d970b04e5905dc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Details), @"mvc.1.0.view", @"/Views/Rooms/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rooms/Details.cshtml", typeof(AspNetCore.Views_Rooms_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13b500220a67c809ce1e202a9d970b04e5905dc9", @"/Views/Rooms/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8df17492fda0035aed1881beeaea7bb718f24b", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDC_Web.Models.Room>
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
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 125, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Room</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(199, 42, false);
#line 14 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomId));

#line default
#line hidden
            EndContext();
            BeginContext(241, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(303, 38, false);
#line 17 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.RoomId));

#line default
#line hidden
            EndContext();
            BeginContext(341, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(402, 48, false);
#line 20 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FloorCeiling));

#line default
#line hidden
            EndContext();
            BeginContext(450, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(512, 44, false);
#line 23 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.FloorCeiling));

#line default
#line hidden
            EndContext();
            BeginContext(556, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(617, 46, false);
#line 26 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotCeiling));

#line default
#line hidden
            EndContext();
            BeginContext(663, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(725, 42, false);
#line 29 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotCeiling));

#line default
#line hidden
            EndContext();
            BeginContext(767, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(828, 44, false);
#line 32 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BotFloor));

#line default
#line hidden
            EndContext();
            BeginContext(872, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(934, 40, false);
#line 35 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.BotFloor));

#line default
#line hidden
            EndContext();
            BeginContext(974, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1035, 46, false);
#line 38 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LootObject));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1143, 42, false);
#line 41 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.LootObject));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1246, 46, false);
#line 44 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RootObject));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1354, 42, false);
#line 47 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.RootObject));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1457, 52, false);
#line 50 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InsideHorizontal));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1571, 48, false);
#line 53 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.InsideHorizontal));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1680, 50, false);
#line 56 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InsideVertical));

#line default
#line hidden
            EndContext();
            BeginContext(1730, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1792, 46, false);
#line 59 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.InsideVertical));

#line default
#line hidden
            EndContext();
            BeginContext(1838, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1899, 53, false);
#line 62 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OutsideHorizontal));

#line default
#line hidden
            EndContext();
            BeginContext(1952, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2014, 49, false);
#line 65 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.OutsideHorizontal));

#line default
#line hidden
            EndContext();
            BeginContext(2063, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2124, 51, false);
#line 68 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OutsideVertical));

#line default
#line hidden
            EndContext();
            BeginContext(2175, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2237, 47, false);
#line 71 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.OutsideVertical));

#line default
#line hidden
            EndContext();
            BeginContext(2284, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2345, 45, false);
#line 74 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrimDepth));

#line default
#line hidden
            EndContext();
            BeginContext(2390, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2452, 41, false);
#line 77 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrimDepth));

#line default
#line hidden
            EndContext();
            BeginContext(2493, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2554, 47, false);
#line 80 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InsideDepth));

#line default
#line hidden
            EndContext();
            BeginContext(2601, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2663, 43, false);
#line 83 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.InsideDepth));

#line default
#line hidden
            EndContext();
            BeginContext(2706, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2767, 40, false);
#line 86 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sill));

#line default
#line hidden
            EndContext();
            BeginContext(2807, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2869, 36, false);
#line 89 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sill));

#line default
#line hidden
            EndContext();
            BeginContext(2905, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2966, 43, false);
#line 92 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Control));

#line default
#line hidden
            EndContext();
            BeginContext(3009, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3071, 39, false);
#line 95 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Control));

#line default
#line hidden
            EndContext();
            BeginContext(3110, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3171, 41, false);
#line 98 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(3212, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3274, 37, false);
#line 101 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(3311, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3372, 47, false);
#line 104 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(3419, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3481, 43, false);
#line 107 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(3524, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3585, 47, false);
#line 110 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(3632, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3694, 43, false);
#line 113 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(3737, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3798, 56, false);
#line 116 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DesignedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3854, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3916, 62, false);
#line 119 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.DesignedByNavigation.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(3978, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4039, 43, false);
#line 122 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(4082, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4144, 50, false);
#line 125 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.ProjectTag));

#line default
#line hidden
            EndContext();
            BeginContext(4194, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4255, 55, false);
#line 128 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(4310, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4372, 61, false);
#line 131 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedByNavigation.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(4433, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(4480, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13b500220a67c809ce1e202a9d970b04e5905dc920578", async() => {
                BeginContext(4573, 4, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-projectId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 136 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
                                  WriteLiteral(Model.ProjectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-projectId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 136 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Details.cshtml"
                                                                      WriteLiteral(Model.RoomId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4581, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(4589, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13b500220a67c809ce1e202a9d970b04e5905dc923621", async() => {
                BeginContext(4611, 12, true);
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
            BeginContext(4627, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDC_Web.Models.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591
