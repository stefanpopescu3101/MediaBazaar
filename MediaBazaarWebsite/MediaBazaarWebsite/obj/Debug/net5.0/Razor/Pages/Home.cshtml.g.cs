#pragma checksum "C:\Users\Rawan\Desktop\prj-s2-cb05\MediaBazaarWebsite\MediaBazaarWebsite\Pages\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57255f0e691e7f8c13adf35ffc57de097fbc2d0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MediaBazaarWebsite.Pages.Pages_Home), @"mvc.1.0.razor-page", @"/Pages/Home.cshtml")]
namespace MediaBazaarWebsite.Pages
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
#line 1 "C:\Users\Rawan\Desktop\prj-s2-cb05\MediaBazaarWebsite\MediaBazaarWebsite\Pages\_ViewImports.cshtml"
using MediaBazaarWebsite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57255f0e691e7f8c13adf35ffc57de097fbc2d0b", @"/Pages/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d251f1dcc51b08e46a0da87e72b0c4693f2d23ce", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Reset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Previous", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Next", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Rawan\Desktop\prj-s2-cb05\MediaBazaarWebsite\MediaBazaarWebsite\Pages\Home.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"page_layout\">\r\n    <div id=\"table_container\">\r\n        <h3 style=\"margin-left:20px\">Welcome  ");
#nullable restore
#line 9 "C:\Users\Rawan\Desktop\prj-s2-cb05\MediaBazaarWebsite\MediaBazaarWebsite\Pages\Home.cshtml"
                                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        <div class=""row"">
            <table float=""left"" class=""col-xs-7 table-bordered table-striped table-condensed table-fixed"">


                <thead>
                    <tr>
                        <th class=""col"">Work shift ID</th>
                        <th class=""col"">Period</th>
                        <th class=""col"">Date</th>
                    </tr>
                </thead>

                <tbody>

");
#nullable restore
#line 24 "C:\Users\Rawan\Desktop\prj-s2-cb05\MediaBazaarWebsite\MediaBazaarWebsite\Pages\Home.cshtml"
                     foreach (var item in Model.workShifts)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"col\">");
#nullable restore
#line 28 "C:\Users\Rawan\Desktop\prj-s2-cb05\MediaBazaarWebsite\MediaBazaarWebsite\Pages\Home.cshtml"
                                       Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"col\">");
#nullable restore
#line 29 "C:\Users\Rawan\Desktop\prj-s2-cb05\MediaBazaarWebsite\MediaBazaarWebsite\Pages\Home.cshtml"
                                       Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"col\">");
#nullable restore
#line 30 "C:\Users\Rawan\Desktop\prj-s2-cb05\MediaBazaarWebsite\MediaBazaarWebsite\Pages\Home.cshtml"
                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Rawan\Desktop\prj-s2-cb05\MediaBazaarWebsite\MediaBazaarWebsite\Pages\Home.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                \r\n            </table>\r\n        </div>\r\n        <div class=\"pagination\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57255f0e691e7f8c13adf35ffc57de097fbc2d0b6996", async() => {
                WriteLiteral("\r\n                <button class=\"btn\"> Show </button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57255f0e691e7f8c13adf35ffc57de097fbc2d0b8713", async() => {
                WriteLiteral("\r\n                <button class=\"btn\"> Previous Month </button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57255f0e691e7f8c13adf35ffc57de097fbc2d0b10440", async() => {
                WriteLiteral("\r\n                <button class=\"btn\"> Next Month </button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n    </div>\r\n    <div id=\"list_container\">\r\n        <div float=\"left\" class=\"wrapper\">\r\n            <div class=\"checkbox_container\">\r\n                <div class=\"title\">Unavailable for work shifts</div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57255f0e691e7f8c13adf35ffc57de097fbc2d0b12409", async() => {
                WriteLiteral(@"

                    <div class='checkbox_wrap'>
                        Monday
                        <input type='checkbox' class='checkbox' name='days[]' value='M' />
                    </div>
                    <div class=""checkbox_wrap"">
                        Tuesday
                        <input type=""checkbox"" class=""checkbox"" name=""days[]"" value=""T"" />
                    </div>
                    <div class=""checkbox_wrap"">
                        Wednesday
                        <input type=""checkbox"" class=""checkbox"" name=""days[]"" value=""W"" />
                    </div>
                    <div class=""checkbox_wrap"">
                        Thursday
                        <input type=""checkbox"" class=""checkbox"" name=""days[]"" value=""Th"" />
                    </div>
                    <div class=""checkbox_wrap"">
                        Friday
                        <input type=""checkbox"" class=""checkbox"" name=""days[]"" value=""F"" />
                    </div>
        ");
                WriteLiteral(@"            <div class=""checkbox_wrap"">
                        Saturday
                        <input type=""checkbox"" class=""checkbox"" name=""days[]"" value=""S"" />
                    </div>
                    <div class=""checkbox_wrap"">
                        Sunday
                        <input type=""checkbox"" class=""checkbox"" name=""days[]"" value=""U"" />
                    </div>

                    <hr>
                    <div class=""checkbox_wrap"">
                        At night shifts
                        <input type=""checkbox"" class=""checkbox"" name=""nightShift"" value=""True"">
                    </div>
                    <input id=""btnSave"" type=""submit"" value=""Save"" />
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaBazaarWebsite.Pages.HomeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MediaBazaarWebsite.Pages.HomeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MediaBazaarWebsite.Pages.HomeModel>)PageContext?.ViewData;
        public MediaBazaarWebsite.Pages.HomeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
