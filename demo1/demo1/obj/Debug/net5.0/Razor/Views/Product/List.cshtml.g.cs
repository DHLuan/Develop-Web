#pragma checksum "D:\TaiLieu\Develop Web\demo1\demo1\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08cf4ec3330c5c36af8fb640cf703dfb7ec2ac2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#nullable restore
#line 1 "D:\TaiLieu\Develop Web\demo1\demo1\Views\_ViewImports.cshtml"
using demo1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TaiLieu\Develop Web\demo1\demo1\Views\_ViewImports.cshtml"
using demo1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08cf4ec3330c5c36af8fb640cf703dfb7ec2ac2a", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2d531fcc1decd85a0aee3bbdc1d49c21cc54e8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<demo1.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "addcart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\TaiLieu\Develop Web\demo1\demo1\Views\Product\List.cshtml"
  
    ViewData["Title"] = "Product Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">

    <div class=""row"">

        <div class=""col-md-9"">

            <div class=""row"">
                <div class=""btn-group alg-right-pad"">
                    <button type=""button"" class=""btn btn-default""><strong>1235  </strong>items</button>
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"">
                            Sort Products &nbsp;
                            <span class=""caret""></span>
                        </button>
                        <ul class=""dropdown-menu"">
                            <li><a href=""#"">By Price Low</a></li>
                            <li class=""divider""></li>
                            <li><a href=""#"">By Price High</a></li>
                            <li class=""divider""></li>
                            <li><a href=""#"">By Popularity</a></li>
                            <li class=""divider""></li>
                            <l");
            WriteLiteral("i><a href=\"#\">By Reviews</a></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 33 "D:\TaiLieu\Develop Web\demo1\demo1\Views\Product\List.cshtml"
                 foreach (var pro in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 text-center col-sm-6 col-xs-6\">\r\n                        <div class=\"thumbnail product-box\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1509, "\"", 1528, 1);
#nullable restore
#line 37 "D:\TaiLieu\Develop Web\demo1\demo1\Views\Product\List.cshtml"
WriteAttributeValue("", 1515, pro.ImageUrl, 1515, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:150px;height:150px;\"");
            BeginWriteAttribute("alt", " alt=\"", 1563, "\"", 1569, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div class=\"caption\">\r\n                                <h3><a");
            BeginWriteAttribute("href", " href=\"", 1664, "\"", 1694, 2);
            WriteAttributeValue("", 1671, "/product/Detail/", 1671, 16, true);
#nullable restore
#line 39 "D:\TaiLieu\Develop Web\demo1\demo1\Views\Product\List.cshtml"
WriteAttributeValue("", 1687, pro.Id, 1687, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "D:\TaiLieu\Develop Web\demo1\demo1\Views\Product\List.cshtml"
                                                                 Write(pro.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h3>\r\n                                <p>Price : <strong>$ ");
#nullable restore
#line 40 "D:\TaiLieu\Develop Web\demo1\demo1\Views\Product\List.cshtml"
                                                Write(pro.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>  </p>\r\n                                <p><a href=\"#\">Ptional dismiss button </a></p>\r\n                                <p>Ptional dismiss button in tional dismiss button in   </p>\r\n                                <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08cf4ec3330c5c36af8fb640cf703dfb7ec2ac2a7734", async() => {
                WriteLiteral("Add To Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\TaiLieu\Develop Web\demo1\demo1\Views\Product\List.cshtml"
                                                                   WriteLiteral(pro.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 2115, "\"", 2145, 2);
            WriteAttributeValue("", 2122, "/product/Detail/", 2122, 16, true);
#nullable restore
#line 43 "D:\TaiLieu\Develop Web\demo1\demo1\Views\Product\List.cshtml"
WriteAttributeValue("", 2138, pro.Id, 2138, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" role=\"button\">See Details</a></p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 47 "D:\TaiLieu\Develop Web\demo1\demo1\Views\Product\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
                <div class=""row"">
                    <ul class=""pagination alg-right-pad"">
                        <li><a href=""#"">&laquo;</a></li>
                        <li><a href=""#"">1</a></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a href=""#"">4</a></li>
                        <li><a href=""#"">5</a></li>
                        <li><a href=""#"">&raquo;</a></li>
                    </ul>
                </div>
            

");
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<demo1.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591