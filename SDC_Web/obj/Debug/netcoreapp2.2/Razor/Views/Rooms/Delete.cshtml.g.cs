#pragma checksum "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "803ebbb2256fc95308bd9e839202acfc31c1b39d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Delete), @"mvc.1.0.view", @"/Views/Rooms/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rooms/Delete.cshtml", typeof(AspNetCore.Views_Rooms_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"803ebbb2256fc95308bd9e839202acfc31c1b39d", @"/Views/Rooms/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8df17492fda0035aed1881beeaea7bb718f24b", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDC_Web.Models.Room>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(72, 174, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Room</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(247, 48, false);
#line 15 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FloorCeiling));

#line default
#line hidden
            EndContext();
            BeginContext(295, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(359, 44, false);
#line 18 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FloorCeiling));

#line default
#line hidden
            EndContext();
            BeginContext(403, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(466, 46, false);
#line 21 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotCeiling));

#line default
#line hidden
            EndContext();
            BeginContext(512, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(576, 42, false);
#line 24 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotCeiling));

#line default
#line hidden
            EndContext();
            BeginContext(618, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(681, 44, false);
#line 27 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BotFloor));

#line default
#line hidden
            EndContext();
            BeginContext(725, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(789, 40, false);
#line 30 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BotFloor));

#line default
#line hidden
            EndContext();
            BeginContext(829, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(892, 46, false);
#line 33 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LootObject));

#line default
#line hidden
            EndContext();
            BeginContext(938, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1002, 42, false);
#line 36 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LootObject));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1107, 46, false);
#line 39 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RootObject));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1217, 42, false);
#line 42 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RootObject));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1322, 52, false);
#line 45 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InsideHorizontal));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1438, 48, false);
#line 48 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InsideHorizontal));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1549, 50, false);
#line 51 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InsideVertical));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1663, 46, false);
#line 54 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InsideVertical));

#line default
#line hidden
            EndContext();
            BeginContext(1709, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1772, 53, false);
#line 57 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OutsideHorizontal));

#line default
#line hidden
            EndContext();
            BeginContext(1825, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1889, 49, false);
#line 60 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OutsideHorizontal));

#line default
#line hidden
            EndContext();
            BeginContext(1938, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2001, 51, false);
#line 63 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OutsideVertical));

#line default
#line hidden
            EndContext();
            BeginContext(2052, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2116, 47, false);
#line 66 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OutsideVertical));

#line default
#line hidden
            EndContext();
            BeginContext(2163, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2226, 45, false);
#line 69 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TrimDepth));

#line default
#line hidden
            EndContext();
            BeginContext(2271, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2335, 41, false);
#line 72 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TrimDepth));

#line default
#line hidden
            EndContext();
            BeginContext(2376, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2439, 47, false);
#line 75 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InsideDepth));

#line default
#line hidden
            EndContext();
            BeginContext(2486, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2550, 43, false);
#line 78 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InsideDepth));

#line default
#line hidden
            EndContext();
            BeginContext(2593, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2656, 40, false);
#line 81 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sill));

#line default
#line hidden
            EndContext();
            BeginContext(2696, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2760, 36, false);
#line 84 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sill));

#line default
#line hidden
            EndContext();
            BeginContext(2796, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2859, 43, false);
#line 87 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Control));

#line default
#line hidden
            EndContext();
            BeginContext(2902, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2966, 39, false);
#line 90 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Control));

#line default
#line hidden
            EndContext();
            BeginContext(3005, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3068, 41, false);
#line 93 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(3109, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3173, 37, false);
#line 96 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(3210, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3273, 47, false);
#line 99 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(3320, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3384, 43, false);
#line 102 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(3427, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3490, 47, false);
#line 105 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(3537, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3601, 43, false);
#line 108 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(3644, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3707, 56, false);
#line 111 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DesignedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3763, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3827, 62, false);
#line 114 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DesignedByNavigation.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(3889, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3958, 43, false);
#line 117 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(4001, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4065, 50, false);
#line 120 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.ProjectTag));

#line default
#line hidden
            EndContext();
            BeginContext(4115, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4184, 55, false);
#line 123 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(4239, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4303, 61, false);
#line 126 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedByNavigation.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(4364, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(4408, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803ebbb2256fc95308bd9e839202acfc31c1b39d20561", async() => {
                BeginContext(4434, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4444, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "803ebbb2256fc95308bd9e839202acfc31c1b39d20954", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 131 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProjectId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4487, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4497, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "803ebbb2256fc95308bd9e839202acfc31c1b39d22771", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 132 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Rooms\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoomId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4537, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(4620, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803ebbb2256fc95308bd9e839202acfc31c1b39d24666", async() => {
                    BeginContext(4642, 12, true);
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
                BeginContext(4658, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4671, 10, true);
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
