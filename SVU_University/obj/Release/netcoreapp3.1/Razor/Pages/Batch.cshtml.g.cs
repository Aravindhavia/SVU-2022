#pragma checksum "E:\Projects\NetCore\UniversityApplication\SVUDDE\SVU_University\Pages\Batch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "723b1adf363d8cb43909383bcb6259fe0a7da838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SVU_University.Pages.Pages_Batch), @"mvc.1.0.razor-page", @"/Pages/Batch.cshtml")]
namespace SVU_University.Pages
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
#line 1 "E:\Projects\NetCore\UniversityApplication\SVUDDE\SVU_University\Pages\_ViewImports.cshtml"
using SVU_University;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723b1adf363d8cb43909383bcb6259fe0a7da838", @"/Pages/Batch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cd7691a3290b10ea46bc96e01ca2464396f33c0", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Batch : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Projects\NetCore\UniversityApplication\SVUDDE\SVU_University\Pages\Batch.cshtml"
  
    ViewData["Title"] = "BatchList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""section-body"">
          <h2 class=""section-title""> Batch Details </h2>
          
          <div class=""container-fluid"">
            <div class=""tab-content"">
             
                <div class=""card"">
                  <div class=""card-body"">
                    <div class=""row"">
                      <div class=""col-lg-3 col-md-4 col-sm-6"">
                        <div class=""input-group"">
                          <input type=""text"" class=""form-control"" placeholder=""Batch Code"">
                        </div>
                      </div>
                      <div class=""col-lg-3 col-md-4 col-sm-6"">
                        <div class=""input-group"">
                          <input type=""text"" class=""form-control"" placeholder=""Batch Title"">
                        </div>
                      </div>
                      <div class=""col-lg-3 col-md-4 col-sm-6"">
                            <div class=""form-group"">
                              <select class=""for");
            WriteLiteral("m-control select2\" data-placeholder=\"Status\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723b1adf363d8cb43909383bcb6259fe0a7da8385772", async() => {
                WriteLiteral(" Select Status ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723b1adf363d8cb43909383bcb6259fe0a7da8387283", async() => {
                WriteLiteral(" Available ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723b1adf363d8cb43909383bcb6259fe0a7da8388479", async() => {
                WriteLiteral(" Blocked ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723b1adf363d8cb43909383bcb6259fe0a7da8389673", async() => {
                WriteLiteral(" Deleted ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723b1adf363d8cb43909383bcb6259fe0a7da83810867", async() => {
                WriteLiteral(" Removed ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                              </select>\r\n                            </div>\r\n                      </div>\r\n                      <div class=\"col-lg-2 col-md-4 col-sm-6\"> <a href=\"#\" class=\"btn btn-primary btn-lg btn-block\"");
            BeginWriteAttribute("title", " title=\"", 1752, "\"", 1760, 0);
            EndWriteAttribute();
            WriteLiteral(@">Search</a> </div>
                      <div class=""col-lg-1 col-md-4 col-sm-6 mt-1""> <a href=""BatchADD"" class=""btn btn-outline-primary btn-rounded ""> Add New <i class=""fa-solid fa-plus""></i> </a> </div>
                    </div>
                  </div>
                </div>
                <div class=""table-responsive card"">
                  <table class=""table table-hover table-vcenter table-striped mb-0 text-nowrap"" data-list="""">
                    <thead>
                      <tr>
                        <th>Batch Code</th>
                        <th>Batch Title</th>
                        <th>Status</th>
                        <th>Action</th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr>
                        <td> AY2001 </td>
                        <td> 2001-2004 </td>
                        <td> Available </td>
                        <td>  <a href=""BatchView"" class=""btn btn-icon text-dark btn-sm"" title=");
            WriteLiteral(@"""View""><i class=""fa fa-eye""></i></a> 
                              <a href=""BatchUpdate"" class=""btn btn-icon btn-sm"" title=""Edit""><i class=""fa fa-edit""></i></a> 
                              <a href=""BatchDelete"" class=""btn btn-sm js-sweetalert"" title=""Delete"" data-type=""confirm""><i class=""fa fa-trash text-danger""></i></a> </td>
                      </tr>
                      <tr>
                        <td> AX2002 </td>
                        <td> 2002-2004 </td>
                        <td> Blocked </td>
                        <td><button type=""button"" class=""btn btn-icon text-dark btn-sm"" title=""View""><i class=""fa fa-eye""></i></button>
                          <button type=""button"" class=""btn btn-icon btn-sm"" title=""Edit""><i class=""fa fa-edit""></i></button>
                          <button type=""button"" class=""btn btn-sm js-sweetalert"" title=""Delete"" data-type=""confirm""><i class=""fa fa-trash text-danger""></i></button></td>
                      </tr>
                      <tr>
       ");
            WriteLiteral(@"                 <td> AZ2001 </td>
                        <td> 2001-2003 </td>
                        <td> Deleted </td>
                        <td><button type=""button"" class=""btn btn-icon text-dark btn-sm"" title=""View""><i class=""fa fa-eye""></i></button>
                          <button type=""button"" class=""btn btn-icon btn-sm"" title=""Edit""><i class=""fa fa-edit""></i></button>
                          <button type=""button"" class=""btn btn-sm js-sweetalert"" title=""Delete"" data-type=""confirm""><i class=""fa fa-trash text-danger""></i></button></td>
                      </tr>
                      
                    </tbody>
                  </table>
                </div>
            </div>
          </div>
        </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SVU_University.Pages.BatchModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SVU_University.Pages.BatchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SVU_University.Pages.BatchModel>)PageContext?.ViewData;
        public SVU_University.Pages.BatchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591