#pragma checksum "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2ec6970c6568e994a51bdfee93696c184cd486e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_CommonStatistics_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/CommonStatistics/Default.cshtml")]
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
#nullable restore
#line 2 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2ec6970c6568e994a51bdfee93696c184cd486e", @"/Areas/Admin/Views/Shared/Components/CommonStatistics/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181066c519b5e3a88fbfc1b430cb86e3463f4c97", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_CommonStatistics_Default : Nop.Web.Framework.Mvc.Razor.NopRazorPage<CommonStatisticsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small-box-footer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReturnRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LowStock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
  
    const string cardId = "nopcommerce-common-statistics-card";
    const string hideCardAttributeName = "HideCommonStatisticsCard";
    var hideCard = await genericAttributeService.GetAttributeAsync<bool>(await workContext.GetCurrentCustomerAsync(), hideCardAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 454, "\"", 535, 4);
            WriteAttributeValue("", 462, "card", 462, 4, true);
            WriteAttributeValue(" ", 466, "card-primary", 467, 13, true);
            WriteAttributeValue(" ", 479, "card-outline", 480, 13, true);
            WriteAttributeValue(" ", 492, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 11 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                                                if(hideCard){

#line default
#line hidden
#nullable disable
                WriteLiteral("collapsed-card");
#nullable restore
#line 11 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 493, 42, false);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 536, "\"", 548, 1);
#nullable restore
#line 11 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
WriteAttributeValue("", 541, cardId, 541, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card-header with-border clearfix\">\r\n            <div class=\"card-title\">\r\n                <i class=\"far fa-chart-bar\"></i>\r\n                ");
#nullable restore
#line 15 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
           Write(T("Admin.Dashboard.CommonStatistics"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-tools float-right\">\r\n                <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"collapse\">\r\n");
#nullable restore
#line 19 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                     if (hideCard)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fas fa-plus\"></i>");
#nullable restore
#line 21 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                                                                
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fas fa-minus\"></i>");
#nullable restore
#line 25 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                                                                 
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </button>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-lg-3 col-6"">
                    <div class=""small-box bg-info"">
                        <div class=""inner"">
                            <h3>");
#nullable restore
#line 35 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                           Write(Model.NumberOfOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 36 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                          Write(T("Admin.Dashboard.NumberOfOrders"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"icon\">\r\n                            <i class=\"ion ion-bag\"></i>\r\n                        </div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2ec6970c6568e994a51bdfee93696c184cd486e23243", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 42 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                       Write(T("Admin.Dashboard.MoreInfo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <i class=\"fas fa-arrow-circle-right\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-3 col-6\">\r\n                    <div class=\"small-box bg-yellow\">\r\n                        <div class=\"inner\">\r\n                            <h3>");
#nullable restore
#line 50 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                           Write(Model.NumberOfPendingReturnRequests);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 51 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                          Write(T("Admin.Dashboard.NumberOfPendingReturnRequests"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"icon\">\r\n                            <i class=\"ion ion-refresh\"></i>\r\n                        </div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2ec6970c6568e994a51bdfee93696c184cd486e26317", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 57 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                       Write(T("Admin.Dashboard.MoreInfo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <i class=\"fas fa-arrow-circle-right\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-3 col-6\">\r\n                    <div class=\"small-box bg-green\">\r\n                        <div class=\"inner\">\r\n                            <h3>");
#nullable restore
#line 65 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                           Write(Model.NumberOfCustomers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 66 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                          Write(T("Admin.Dashboard.NumberOfCustomers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"icon\">\r\n                            <i class=\"ion ion-person-add\"></i>\r\n                        </div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2ec6970c6568e994a51bdfee93696c184cd486e29369", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 72 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                       Write(T("Admin.Dashboard.MoreInfo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <i class=\"fas fa-arrow-circle-right\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-3 col-6\">\r\n                    <div class=\"small-box bg-red\">\r\n                        <div class=\"inner\">\r\n                            <h3>");
#nullable restore
#line 80 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                           Write(Model.NumberOfLowStockProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 81 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                          Write(T("Admin.Dashboard.NumberOfLowStockProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"icon\">\r\n                            <i class=\"ion ion-pie-graph\"></i>\r\n                        </div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2ec6970c6568e994a51bdfee93696c184cd486e32432", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 87 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                       Write(T("Admin.Dashboard.MoreInfo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <i class=\"fas fa-arrow-circle-right\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <script>\r\n            $(document).ready(function () {\r\n                $(\'#");
#nullable restore
#line 95 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
               Write(cardId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').on(\'click\', \'button[data-card-widget=\"collapse\"]\', function () {\r\n                    var collapsed = !$(\'#");
#nullable restore
#line 96 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                                    Write(cardId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').hasClass(\'collapsed-card\');\r\n                    saveUserPreferences(\'");
#nullable restore
#line 97 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                                     Write(Url.Action("SavePreference", "Preferences"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 97 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Shared\Components\CommonStatistics\Default.cshtml"
                                                                                      Write(hideCardAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', collapsed);\r\n                });\r\n            });\r\n                </script>\r\n            </div>\r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Common.IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommonStatisticsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
