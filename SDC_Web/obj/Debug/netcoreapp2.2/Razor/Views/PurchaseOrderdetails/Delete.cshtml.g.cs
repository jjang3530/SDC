#pragma checksum "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14265621eeb2af09262161785a953b6dda35305e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrderdetails_Delete), @"mvc.1.0.view", @"/Views/PurchaseOrderdetails/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseOrderdetails/Delete.cshtml", typeof(AspNetCore.Views_PurchaseOrderdetails_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14265621eeb2af09262161785a953b6dda35305e", @"/Views/PurchaseOrderdetails/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8df17492fda0035aed1881beeaea7bb718f24b", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrderdetails_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDC_Web.Models.PurchaseOrderdetail>
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(87, 189, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>PurchaseOrderdetail</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(277, 45, false);
#line 15 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dimension));

#line default
#line hidden
            EndContext();
            BeginContext(322, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(386, 41, false);
#line 18 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dimension));

#line default
#line hidden
            EndContext();
            BeginContext(427, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(490, 47, false);
#line 21 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(537, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(601, 43, false);
#line 24 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(644, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(707, 43, false);
#line 27 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pattern));

#line default
#line hidden
            EndContext();
            BeginContext(750, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(814, 39, false);
#line 30 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pattern));

#line default
#line hidden
            EndContext();
            BeginContext(853, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(916, 42, false);
#line 33 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Colour));

#line default
#line hidden
            EndContext();
            BeginContext(958, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1022, 38, false);
#line 36 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Colour));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1123, 44, false);
#line 39 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1231, 40, false);
#line 42 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1334, 39, false);
#line 45 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Uom));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1437, 35, false);
#line 48 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Uom));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1535, 45, false);
#line 51 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1580, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1644, 41, false);
#line 54 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1748, 42, false);
#line 57 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1854, 38, false);
#line 60 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1955, 50, false);
#line 63 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeliveryStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2069, 46, false);
#line 66 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeliveryStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2115, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2178, 47, false);
#line 69 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(2225, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2289, 43, false);
#line 72 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2395, 47, false);
#line 75 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(2442, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2506, 43, false);
#line 78 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(2549, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2612, 55, false);
#line 81 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2667, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2731, 61, false);
#line 84 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OrderedByNavigation.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2792, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2861, 49, false);
#line 87 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PurchaseOrder));

#line default
#line hidden
            EndContext();
            BeginContext(2910, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2974, 61, false);
#line 90 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PurchaseOrder.ShippingAddress));

#line default
#line hidden
            EndContext();
            BeginContext(3035, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3104, 55, false);
#line 93 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3159, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3223, 61, false);
#line 96 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedByNavigation.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(3284, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3328, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14265621eeb2af09262161785a953b6dda35305e16982", async() => {
                BeginContext(3354, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3364, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14265621eeb2af09262161785a953b6dda35305e17375", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 101 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
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
                BeginContext(3407, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3417, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14265621eeb2af09262161785a953b6dda35305e19207", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 102 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderId);

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
                BeginContext(3458, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3468, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14265621eeb2af09262161785a953b6dda35305e21037", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 103 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrderdetails\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

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
                BeginContext(3511, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3594, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14265621eeb2af09262161785a953b6dda35305e22950", async() => {
                    BeginContext(3616, 12, true);
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
                BeginContext(3632, 6, true);
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
            BeginContext(3645, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDC_Web.Models.PurchaseOrderdetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
