#pragma checksum "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "869323d65ea5b262febd4e5200c42f8bd01f2d34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product__CreateOrUpdate_StockQuantityHistory), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/_CreateOrUpdate.StockQuantityHistory.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 9 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.MultiFactorAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869323d65ea5b262febd4e5200c42f8bd01f2d34", @"/Areas/Admin/Views/Product/_CreateOrUpdate.StockQuantityHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181066c519b5e3a88fbfc1b430cb86e3463f4c97", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product__CreateOrUpdate_StockQuantityHistory : Nop.Web.Framework.Mvc.Razor.NopRazorPage<ProductModel>
    {
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
        private global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card-body\">\r\n    <p>\r\n        ");
#nullable restore
#line 5 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml"
   Write(T("Admin.Catalog.Products.StockQuantityHistory.Hint"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    ");
#nullable restore
#line 7 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml"
Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.ProductDetailsStockQuantityHistoryTop, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    <div ");
#nullable restore
#line 9 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml"
     Write(Model.StockQuantityHistorySearchModel.AvailableWarehouses.SelectionIsNotPossible() ? Html.Raw("style=\"display:none\"") : null);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n        <div class=\"form-group row\" ");
#nullable restore
#line 10 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml"
                                Write(Model.StockQuantityHistorySearchModel.AvailableWarehouses.SelectionIsNotPossible() ? Html.Raw("style=\"display:none\"") : null);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n            <div class=\"col-md-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "869323d65ea5b262febd4e5200c42f8bd01f2d3417708", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 12 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StockQuantityHistorySearchModel.WarehouseId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "869323d65ea5b262febd4e5200c42f8bd01f2d3419336", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper);
#nullable restore
#line 15 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StockQuantityHistorySearchModel.WarehouseId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items = Model.StockQuantityHistorySearchModel.AvailableWarehouses;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <div class=""form-group row"">
            <div class=""col-md-9 offset-md-3"">
                <button type=""button"" id=""search-stock-quantity-history"" class=""btn btn-primary btn-search"">
                    <i class=""fas fa-search""></i>
                    ");
#nullable restore
#line 22 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml"
               Write(T("Admin.Common.Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n        \r\n    ");
#nullable restore
#line 28 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml"
Write(await Html.PartialAsync("Table", new DataTablesModel
    {
        Name = "stock-quantity-history-grid",
        UrlRead = new DataUrl("StockQuantityHistory", "Product", new RouteValueDictionary { [nameof(Model.StockQuantityHistorySearchModel.ProductId)] = Model.StockQuantityHistorySearchModel.ProductId }),
        SearchButtonId = "search-stock-quantity-history",
        Length = Model.StockQuantityHistorySearchModel.PageSize,
        LengthMenu = Model.StockQuantityHistorySearchModel.AvailablePageSizes,
        Filters = new List<FilterParameter>
        {
            new FilterParameter(nameof(StockQuantityHistorySearchModel.WarehouseId), nameof(StockQuantityHistorySearchModel))
        },
        ColumnCollection = new List<ColumnProperty>
        {
            new ColumnProperty(nameof(StockQuantityHistoryModel.WarehouseName))
            {
                Title = T("Admin.Catalog.Products.StockQuantityHistory.Fields.Warehouse").Text,
                Width = "150"
            },
            new ColumnProperty(nameof(StockQuantityHistoryModel.AttributeCombination))
            {
                Title = T("Admin.Catalog.Products.StockQuantityHistory.Fields.Combination").Text,
                Width = "180",
                Encode = false
            },
            new ColumnProperty(nameof(StockQuantityHistoryModel.QuantityAdjustment))
            {
                Title = T("Admin.Catalog.Products.StockQuantityHistory.Fields.QuantityAdjustment").Text,
                Width = "150",
                Render = new RenderCustom("renderStockQuantityHistoryQuantityAdjustment")
            },
            new ColumnProperty(nameof(StockQuantityHistoryModel.StockQuantity))
            {
                Title = T("Admin.Catalog.Products.StockQuantityHistory.Fields.StockQuantity").Text,
                Width = "130"
            },
            new ColumnProperty(nameof(StockQuantityHistoryModel.Message))
            {
                Title = T("Admin.Catalog.Products.StockQuantityHistory.Fields.Message").Text
            },
            new ColumnProperty(nameof(StockQuantityHistoryModel.CreatedOn))
            {
                Title = T("Admin.Catalog.Products.StockQuantityHistory.Fields.CreatedOn").Text,
                Width = "170",
                Render = new RenderDate()
            }
        }
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <script>\r\n        function renderStockQuantityHistoryQuantityAdjustment(data, type, row, meta) {\r\n            return (data > 0 ? \'+\' : \'\') + data;\r\n        }\r\n    </script>\r\n    ");
#nullable restore
#line 80 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.StockQuantityHistory.cshtml"
Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.ProductDetailsStockQuantityHistoryBottom, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
