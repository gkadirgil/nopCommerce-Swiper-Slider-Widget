#pragma checksum "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.CrossSellsProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa74bf5cfac4b2ee91323bb8cd423d851b61eb9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product__CreateOrUpdate_CrossSellsProducts), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/_CreateOrUpdate.CrossSellsProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa74bf5cfac4b2ee91323bb8cd423d851b61eb9b", @"/Areas/Admin/Views/Product/_CreateOrUpdate.CrossSellsProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181066c519b5e3a88fbfc1b430cb86e3463f4c97", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product__CreateOrUpdate_CrossSellsProducts : Nop.Web.Framework.Mvc.Razor.NopRazorPage<ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card-body\">\r\n    <p>\r\n        ");
#nullable restore
#line 4 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.CrossSellsProducts.cshtml"
   Write(T("Admin.Catalog.Products.CrossSells.Hint"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 6 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.CrossSellsProducts.cshtml"
     if (Model.Id > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card card-default\">\r\n\r\n        <div class=\"card-body\">\r\n            ");
#nullable restore
#line 11 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.CrossSellsProducts.cshtml"
       Write(await Html.PartialAsync("Table", new DataTablesModel
            {
                Name = "crosssellproducts-grid",
                UrlRead = new DataUrl("CrossSellProductList", "Product", new RouteValueDictionary { [nameof(Model.CrossSellProductSearchModel.ProductId)] = Model.CrossSellProductSearchModel.ProductId }),
                UrlDelete = new DataUrl("CrossSellProductDelete", "Product", null),
                Length = Model.CrossSellProductSearchModel.PageSize,
                LengthMenu = Model.CrossSellProductSearchModel.AvailablePageSizes,
                ColumnCollection = new List<ColumnProperty>
                {
                    new ColumnProperty(nameof(CrossSellProductModel.Product2Name))
                    {
                        Title = T("Admin.Catalog.Products.CrossSells.Fields.Product").Text,
                        Render = new RenderCustom("renderColumnCrossSellProductName")
                    },
                    new ColumnProperty(nameof(CrossSellProductModel.Id))
                    {
                        Title = T("Admin.Common.Delete").Text,
                        Width = "100",
                        Render = new RenderButtonRemove(T("Admin.Common.Delete").Text),
                        ClassName = NopColumnClassDefaults.Button
                    }
                }
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <script>\r\n                function renderColumnCrossSellProductName(data, type, row, meta) {\r\n                    var textRenderer = $.fn.dataTable.render.text().display;\r\n                    return \'<a href=\"");
#nullable restore
#line 37 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.CrossSellsProducts.cshtml"
                                Write(Url.Content("~/Admin/Product/Edit/"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + row.ProductId2 + \'\">\' + textRenderer(row.Product2Name) + \'</a>\';\r\n                }\r\n            </script>\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <button type=\"submit\" id=\"btnAddNewCrossSellProduct\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2089, "\"", 2299, 8);
            WriteAttributeValue("", 2099, "javascript:OpenWindow(\'", 2099, 23, true);
#nullable restore
#line 42 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.CrossSellsProducts.cshtml"
WriteAttributeValue("", 2122, Url.Action("CrossSellProductAddPopup", "Product", new {productId = Model.Id, btnId = "btnRefreshCrossSellProducts", formId = "product-form"}), 2122, 144, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2266, "\',", 2266, 2, true);
            WriteAttributeValue(" ", 2268, "800,", 2269, 5, true);
            WriteAttributeValue(" ", 2273, "800,", 2274, 5, true);
            WriteAttributeValue(" ", 2278, "true);", 2279, 7, true);
            WriteAttributeValue(" ", 2285, "return", 2286, 7, true);
            WriteAttributeValue(" ", 2292, "false;", 2293, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">\r\n                ");
#nullable restore
#line 43 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.CrossSellsProducts.cshtml"
           Write(T("Admin.Catalog.Products.CrossSells.AddNew"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </button>
            <button type=""submit"" id=""btnRefreshCrossSellProducts"" style=""display: none""></button>
            <script>
                $(document).ready(function () {
                    $('#btnRefreshCrossSellProducts').click(function () {
                        //refresh grid
                        updateTable('#crosssellproducts-grid');

                        //return false to don't reload a page
                        return false;
                    });
                });
            </script>
        </div>
    </div>
");
#nullable restore
#line 59 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.CrossSellsProducts.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card card-default\">\r\n            <div class=\"card-body\">\r\n                ");
#nullable restore
#line 64 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.CrossSellsProducts.cshtml"
           Write(T("Admin.Catalog.Products.CrossSells.SaveBeforeEdit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Users\gkadi\source\repos\nopCommerce_4.40.3_Source\src\Presentation\Nop.Web\Areas\Admin\Views\Product\_CreateOrUpdate.CrossSellsProducts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
