#pragma checksum "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e910f980d2bc64fd57224c997a02c90ee8bd4821"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BooksModels__ViewAll), @"mvc.1.0.view", @"/Views/BooksModels/_ViewAll.cshtml")]
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
#line 1 "D:\C#\C#Projects\MyBooks\MyBooks\Views\_ViewImports.cshtml"
using MyBooks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\C#Projects\MyBooks\MyBooks\Views\_ViewImports.cshtml"
using MyBooks.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e910f980d2bc64fd57224c997a02c90ee8bd4821", @"/Views/BooksModels/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da1ee1178a931a732d44691a38db717c0fdb5477", @"/Views/_ViewImports.cshtml")]
    public class Views_BooksModels__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyBooks.Models.BooksModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Видалити", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"col-md-8 offset-md-2\">\n\n    <h1 class=\"text-center\"><i class=\"fas text-success\"></i> Мої книги</h1>\n\n\n    <table class=\"table\">\n        <thead class=\"thead-light\">\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 12 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.nameBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 15 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.genreBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 18 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 21 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.authorBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 24 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.pagesBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 828, "\"", 929, 3);
            WriteAttributeValue("", 838, "showInPopup(\'", 838, 13, true);
#nullable restore
#line 27 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
WriteAttributeValue("", 851, Url.Action("AddOrEdit","BooksModels",null,Context.Request.Scheme), 851, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 917, "\',\'AddBook\')", 917, 12, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\"> Добавити книгу</a>\n                </th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 32 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 36 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
   Write(Html.DisplayFor(modelItem => item.nameBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 39 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
   Write(Html.DisplayFor(modelItem => item.genreBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 42 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
   Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <th>\n        ");
#nullable restore
#line 45 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
   Write(Html.DisplayFor(modelItem => item.authorBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </th>\n    <td>\n        ");
#nullable restore
#line 48 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
   Write(Html.DisplayFor(modelItem => item.pagesBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        <div>\n            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1516, "\"", 1623, 3);
            WriteAttributeValue("", 1526, "showInPopup(\'", 1526, 13, true);
#nullable restore
#line 52 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
WriteAttributeValue("", 1539, Url.Action("AddOrEdit","BooksModels",new {id=item.bookId},Context.Request.Scheme), 1539, 82, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1621, "\')", 1621, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-pencil-alt\"></i> Редагувати</a>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e910f980d2bc64fd57224c997a02c90ee8bd48219472", async() => {
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e910f980d2bc64fd57224c997a02c90ee8bd48219744", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 54 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.bookId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <input type=\"submit\" value=\"Видалити\" class=\"btn btn-danger\" />\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
                                          WriteLiteral(item.bookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </td>\n</tr>\n");
#nullable restore
#line 60 "D:\C#\C#Projects\MyBooks\MyBooks\Views\BooksModels\_ViewAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyBooks.Models.BooksModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
