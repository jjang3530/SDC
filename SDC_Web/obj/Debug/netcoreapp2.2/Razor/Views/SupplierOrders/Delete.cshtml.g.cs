#pragma checksum "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fa30742aacc1aa491bcd1186c18006c80ec471f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SupplierOrders_Delete), @"mvc.1.0.view", @"/Views/SupplierOrders/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SupplierOrders/Delete.cshtml", typeof(AspNetCore.Views_SupplierOrders_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa30742aacc1aa491bcd1186c18006c80ec471f", @"/Views/SupplierOrders/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8df17492fda0035aed1881beeaea7bb718f24b", @"/Views/_ViewImports.cshtml")]
    public class Views_SupplierOrders_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDC_Web.Models.SupplierOrder>
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(81, 183, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>SupplierOrder</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(265, 50, false);
#line 15 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderingMethod));

#line default
#line hidden
            EndContext();
            BeginContext(315, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(379, 46, false);
#line 18 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OrderingMethod));

#line default
#line hidden
            EndContext();
            BeginContext(425, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(488, 49, false);
#line 21 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderingEmail));

#line default
#line hidden
            EndContext();
            BeginContext(537, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(601, 45, false);
#line 24 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OrderingEmail));

#line default
#line hidden
            EndContext();
            BeginContext(646, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(709, 46, false);
#line 27 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PriceFound));

#line default
#line hidden
            EndContext();
            BeginContext(755, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(819, 42, false);
#line 30 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PriceFound));

#line default
#line hidden
            EndContext();
            BeginContext(861, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(924, 46, false);
#line 33 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountOw));

#line default
#line hidden
            EndContext();
            BeginContext(970, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1034, 42, false);
#line 36 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiscountOw));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1139, 46, false);
#line 39 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountOr));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1249, 42, false);
#line 42 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiscountOr));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1354, 49, false);
#line 45 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountNotes));

#line default
#line hidden
            EndContext();
            BeginContext(1403, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1467, 45, false);
#line 48 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiscountNotes));

#line default
#line hidden
            EndContext();
            BeginContext(1512, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1575, 41, false);
#line 51 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Terms));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1680, 37, false);
#line 54 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Terms));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1780, 44, false);
#line 57 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LeadTime));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1888, 40, false);
#line 60 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LeadTime));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1991, 44, false);
#line 63 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesReq));

#line default
#line hidden
            EndContext();
            BeginContext(2035, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2099, 40, false);
#line 66 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SalesReq));

#line default
#line hidden
            EndContext();
            BeginContext(2139, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2202, 41, false);
#line 69 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Books));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2307, 37, false);
#line 72 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Books));

#line default
#line hidden
            EndContext();
            BeginContext(2344, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2407, 49, false);
#line 75 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentMethod));

#line default
#line hidden
            EndContext();
            BeginContext(2456, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2520, 45, false);
#line 78 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PaymentMethod));

#line default
#line hidden
            EndContext();
            BeginContext(2565, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2628, 48, false);
#line 81 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentNotes));

#line default
#line hidden
            EndContext();
            BeginContext(2676, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2740, 44, false);
#line 84 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PaymentNotes));

#line default
#line hidden
            EndContext();
            BeginContext(2784, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2847, 44, false);
#line 87 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(2891, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2955, 48, false);
#line 90 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Supplier.Company));

#line default
#line hidden
            EndContext();
            BeginContext(3003, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3047, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fa30742aacc1aa491bcd1186c18006c80ec471f15861", async() => {
                BeginContext(3073, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3083, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9fa30742aacc1aa491bcd1186c18006c80ec471f16254", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 95 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\SupplierOrders\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SupplierId);

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
                BeginContext(3127, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3210, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fa30742aacc1aa491bcd1186c18006c80ec471f18161", async() => {
                    BeginContext(3232, 12, true);
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
                BeginContext(3248, 6, true);
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
            BeginContext(3261, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDC_Web.Models.SupplierOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591