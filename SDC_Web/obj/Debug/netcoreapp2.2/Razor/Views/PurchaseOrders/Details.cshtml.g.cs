#pragma checksum "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e532c2bc64974c2015369178271421a558d409c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrders_Details), @"mvc.1.0.view", @"/Views/PurchaseOrders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseOrders/Details.cshtml", typeof(AspNetCore.Views_PurchaseOrders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e532c2bc64974c2015369178271421a558d409c0", @"/Views/PurchaseOrders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8df17492fda0035aed1881beeaea7bb718f24b", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDC_Web.Models.PurchaseOrder>
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 136, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>PurchaseOrder</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(219, 49, false);
#line 14 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShippingPlace));

#line default
#line hidden
            EndContext();
            BeginContext(268, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(332, 45, false);
#line 17 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShippingPlace));

#line default
#line hidden
            EndContext();
            BeginContext(377, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(440, 51, false);
#line 20 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShippingAddress));

#line default
#line hidden
            EndContext();
            BeginContext(491, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(555, 47, false);
#line 23 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShippingAddress));

#line default
#line hidden
            EndContext();
            BeginContext(602, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(665, 49, false);
#line 26 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShippingPhone));

#line default
#line hidden
            EndContext();
            BeginContext(714, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(778, 45, false);
#line 29 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShippingPhone));

#line default
#line hidden
            EndContext();
            BeginContext(823, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(886, 53, false);
#line 32 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstimatedShipdate));

#line default
#line hidden
            EndContext();
            BeginContext(939, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1003, 49, false);
#line 35 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstimatedShipdate));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1115, 47, false);
#line 38 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1226, 43, false);
#line 41 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1332, 47, false);
#line 44 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1443, 43, false);
#line 47 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1549, 55, false);
#line 50 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1668, 61, false);
#line 53 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderedByNavigation.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1792, 43, false);
#line 56 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(1835, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1899, 50, false);
#line 59 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.ProjectTag));

#line default
#line hidden
            EndContext();
            BeginContext(1949, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2012, 44, false);
#line 62 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(2056, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2120, 48, false);
#line 65 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Supplier.Company));

#line default
#line hidden
            EndContext();
            BeginContext(2168, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2231, 55, false);
#line 68 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2286, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2350, 61, false);
#line 71 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedByNavigation.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2411, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2458, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e532c2bc64974c2015369178271421a558d409c012719", async() => {
                BeginContext(2553, 4, true);
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
#line 76 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
                                  WriteLiteral(Model.ProjectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-projectId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\Jay\source\repos\SDC\SDC_Web\Views\PurchaseOrders\Details.cshtml"
                                                                       WriteLiteral(Model.OrderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2561, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2569, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e532c2bc64974c2015369178271421a558d409c015783", async() => {
                BeginContext(2591, 12, true);
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
            BeginContext(2607, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDC_Web.Models.PurchaseOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
