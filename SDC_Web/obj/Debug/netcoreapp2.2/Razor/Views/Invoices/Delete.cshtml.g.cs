#pragma checksum "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a04553d63f69fb665186fc99f67709e4cbaa19f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoices_Delete), @"mvc.1.0.view", @"/Views/Invoices/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoices/Delete.cshtml", typeof(AspNetCore.Views_Invoices_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a04553d63f69fb665186fc99f67709e4cbaa19f2", @"/Views/Invoices/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8df17492fda0035aed1881beeaea7bb718f24b", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoices_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDC_Web.Models.Invoice>
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(75, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Invoice</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(253, 47, false);
#line 15 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InvoiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(300, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(364, 43, false);
#line 18 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InvoiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(407, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(470, 41, false);
#line 21 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Terms));

#line default
#line hidden
            EndContext();
            BeginContext(511, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(575, 37, false);
#line 24 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Terms));

#line default
#line hidden
            EndContext();
            BeginContext(612, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(675, 45, false);
#line 27 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BillPlace));

#line default
#line hidden
            EndContext();
            BeginContext(720, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(784, 41, false);
#line 30 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BillPlace));

#line default
#line hidden
            EndContext();
            BeginContext(825, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(888, 47, false);
#line 33 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BillAddress));

#line default
#line hidden
            EndContext();
            BeginContext(935, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(999, 43, false);
#line 36 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BillAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1105, 45, false);
#line 39 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BillPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1214, 41, false);
#line 42 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BillPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1318, 45, false);
#line 45 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BillEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1427, 41, false);
#line 48 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BillEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1531, 45, false);
#line 51 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipPlace));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1640, 41, false);
#line 54 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ShipPlace));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1744, 47, false);
#line 57 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1855, 43, false);
#line 60 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1961, 44, false);
#line 63 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2069, 40, false);
#line 66 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2172, 44, false);
#line 69 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Shipping));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2280, 40, false);
#line 72 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Shipping));

#line default
#line hidden
            EndContext();
            BeginContext(2320, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2383, 39, false);
#line 75 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hst));

#line default
#line hidden
            EndContext();
            BeginContext(2422, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2486, 35, false);
#line 78 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hst));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2584, 47, false);
#line 81 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2631, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2695, 43, false);
#line 84 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2738, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2801, 47, false);
#line 87 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(2848, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2912, 43, false);
#line 90 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(2955, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3018, 47, false);
#line 93 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(3065, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3129, 43, false);
#line 96 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(3172, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3235, 55, false);
#line 99 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InvoiceByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3290, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3354, 61, false);
#line 102 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InvoiceByNavigation.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(3415, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3484, 43, false);
#line 105 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(3527, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3591, 50, false);
#line 108 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.ProjectTag));

#line default
#line hidden
            EndContext();
            BeginContext(3641, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3710, 55, false);
#line 111 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3765, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3829, 61, false);
#line 114 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedByNavigation.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(3890, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3934, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a04553d63f69fb665186fc99f67709e4cbaa19f218996", async() => {
                BeginContext(3960, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3970, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a04553d63f69fb665186fc99f67709e4cbaa19f219389", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 119 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\Invoices\Delete.cshtml"
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
                BeginContext(4013, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(4096, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a04553d63f69fb665186fc99f67709e4cbaa19f221290", async() => {
                    BeginContext(4118, 12, true);
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
                BeginContext(4134, 6, true);
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
            BeginContext(4147, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDC_Web.Models.Invoice> Html { get; private set; }
    }
}
#pragma warning restore 1591
