#pragma checksum "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a80098f87b6a3660f0ee1ad110535b51ea684ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EmailAccount_List), @"mvc.1.0.view", @"/Areas/Admin/Views/EmailAccount/List.cshtml")]
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
#nullable restore
#line 3 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
using Nop.Web.Framework.Models.AdminAreaTour;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a80098f87b6a3660f0ee1ad110535b51ea684ef", @"/Areas/Admin/Views/EmailAccount/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181066c519b5e3a88fbfc1b430cb86e3463f4c97", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_EmailAccount_List : Nop.Web.Framework.Mvc.Razor.NopRazorPage<EmailAccountSearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Nop.Web.Framework.TagHelpers.Admin.NopDocReferenceTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
  
  //page title
  ViewBag.PageTitle = T("Admin.Configuration.EmailAccounts").Text;
  //tour step
  ViewBag.TourStep = TourStep.EmailAccountList;
  //active menu item (system name)
  Html.SetActiveMenuItemSystemName("Email accounts");

  string editQueryString = string.Empty;
  var showTour = ViewBag.ShowTour ?? false;
  if (showTour)
  {
      editQueryString = "?showtour=true";
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
Write(await Html.PartialAsync("_AdminTour"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"content-header clearfix\">\r\n    <h1 class=\"float-left\">\r\n        ");
#nullable restore
#line 25 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
   Write(T("Admin.Configuration.EmailAccounts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"float-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a80098f87b6a3660f0ee1ad110535b51ea684ef18071", async() => {
                WriteLiteral("\r\n            <i class=\"fas fa-plus-square\"></i>\r\n            ");
#nullable restore
#line 30 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
       Write(T("Admin.Common.AddNew"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
#nullable restore
#line 32 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
   Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.EmailAccountListButtons }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

  <section class=""content"">
   <div class=""container-fluid"">
    <div class=""form-horizontal"">
        <div class=""cards-group"">
            <div class=""card card-default"">
                <div class=""card-body"">
                    <div id=""email-accounts-area"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-doc-reference", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a80098f87b6a3660f0ee1ad110535b51ea684ef20357", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopDocReferenceTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
                                                    WriteLiteral(T("Admin.Documentation.Reference.EmailAccounts", Docs.EmailAccounts + Utm.OnAdmin));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper.StringResource = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-string-resource", __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper.StringResource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 45 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
                   Write(await Html.PartialAsync("Table", new DataTablesModel
                        {
                            Name = "email-accounts-grid",
                            RowIdBasedOnField = nameof(EmailAccountModel.Email),
                            UrlRead = new DataUrl("List", "EmailAccount", null),
                            Length = Model.PageSize,
                            LengthMenu = Model.AvailablePageSizes,
                            ColumnCollection = new List<ColumnProperty>
                            {
                                new ColumnProperty(nameof(EmailAccountModel.Email))
                                {
                                    Title = T("Admin.Configuration.EmailAccounts.Fields.Email").Text
                                },
                                new ColumnProperty(nameof(EmailAccountModel.DisplayName))
                                {
                                    Title = T("Admin.Configuration.EmailAccounts.Fields.DisplayName").Text,
                                    Width = "200"
                                },
                                new ColumnProperty(nameof(EmailAccountModel.IsDefaultEmailAccount))
                                {
                                    Title = T("Admin.Configuration.EmailAccounts.Fields.IsDefaultEmailAccount").Text,
                                    Width = "200",
                                    ClassName =  NopColumnClassDefaults.CenterAll,
                                    Render = new RenderBoolean()
                                },
                                new ColumnProperty(nameof(EmailAccountModel.Id))
                                {
                                    Title = T("Admin.Configuration.EmailAccounts.Fields.MarkAsDefaultEmail").Text,
                                    Width = "300",
                                    ClassName =  NopColumnClassDefaults.CenterAll + " column-default",
                                    Render = new RenderButtonCustom(NopButtonClassDefaults.Success, T("Admin.Configuration.EmailAccounts.Fields.MarkAsDefaultEmail").Text)
                                    {
                                        Url = Url.Content("~/Admin/EmailAccount/MarkAsDefaultEmail/")
                                    }
                                },
                                new ColumnProperty(nameof(EmailAccountModel.Id))
                                {
                                    Title = T("Admin.Common.Edit").Text,
                                    Width = "100",
                                    ClassName =  NopColumnClassDefaults.Button + " column-edit",
                                    Render = new RenderCustom("renderColumnEdit")
                                }
                            }
                        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</section>\r\n\r\n<script>\r\n    function renderColumnEdit(data, type, row, meta) {\r\n        return \'<a href=\"");
#nullable restore
#line 99 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
                    Write(Url.Content("~/Admin/EmailAccount/Edit/"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + data + \'");
#nullable restore
#line 99 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
                                                                           Write(editQueryString);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-default\"><i class=\"fas fa-pencil-alt\"></i>");
#nullable restore
#line 99 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\EmailAccount\List.cshtml"
                                                                                                                                                       Write(T("Admin.Common.Edit").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\';\r\n    }\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Messages.IEmailAccountService emailAccountService { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmailAccountSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
