#pragma checksum "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7eb90ac55ac8a74de5fb7867cdfee3278d15fa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_Index), @"mvc.1.0.view", @"/Views/Note/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Note/Index.cshtml", typeof(AspNetCore.Views_Note_Index))]
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
#line 1 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/_ViewImports.cshtml"
using NetNote;

#line default
#line hidden
#line 2 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/_ViewImports.cshtml"
using NetNote.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7eb90ac55ac8a74de5fb7867cdfee3278d15fa9", @"/Views/Note/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ca0ce1c1a789cbc8243d4e78af112bf3a1537b", @"/Views/_ViewImports.cshtml")]
    public class Views_Note_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetNote.Models.Note>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
  
  var pageindex = Convert.ToInt32(ViewBag.PageIndex);
  var pagecount = Convert.ToInt32(ViewBag.PageCount);
  var pagestart = pageindex - 2 > 0 ? pageindex - 2 : 1;
  var pageend = pageindex + 2 >= pagecount ? pagecount : pagestart + 4;

#line default
#line hidden
            BeginContext(282, 62, true);
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(344, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa3c2a9f2b844c5fa99c0fc1eb378e70", async() => {
                BeginContext(364, 6, true);
                WriteLiteral("添加Note");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(374, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 12 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
     foreach(var item in Model){

#line default
#line hidden
            BeginContext(422, 35, true);
            WriteLiteral("    <div class=\"row\">\r\n        <h3>");
            EndContext();
            BeginContext(458, 10, false);
#line 14 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(468, 22, true);
            WriteLiteral("</h3>\r\n        <h5>类型：");
            EndContext();
            BeginContext(491, 14, false);
#line 15 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
          Write(item.Type.Name);

#line default
#line hidden
            EndContext();
            BeginContext(505, 35, true);
            WriteLiteral("</h5>\r\n        <div class=\"content\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 540, "\"", 556, 2);
            WriteAttributeValue("", 545, "md_", 545, 3, true);
#line 16 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
WriteAttributeValue("", 548, item.Id, 548, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(557, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(559, 12, false);
#line 16 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
                                         Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(571, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 17 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
         if (!string.IsNullOrEmpty(item.Attachment))
    {

#line default
#line hidden
            BeginContext(640, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 646, "\"", 669, 1);
#line 19 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
WriteAttributeValue("", 653, item.Attachment, 653, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(670, 7, true);
            WriteLiteral(">下载</a>");
            EndContext();
#line 19 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
                                     }
else
{

#line default
#line hidden
            BeginContext(689, 21, true);
            WriteLiteral("    <div class=\"row\">");
            EndContext();
            BeginContext(710, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a969a4954ab412c8e1ed23554d5d99b", async() => {
                BeginContext(757, 5, true);
                WriteLiteral("内容已加密");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(766, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 23 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
                      }

#line default
#line hidden
            BeginContext(799, 28, true);
            WriteLiteral("        <hr />\r\n    </div>\r\n");
            EndContext();
#line 26 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(838, 55, true);
            WriteLiteral("</div>\r\n<nav>\r\n    <ul class=\"pagination\">\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 893, "\"", 930, 1);
#line 30 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
WriteAttributeValue("", 901, pageindex==1?"disabled":"", 901, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(931, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(946, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59823913370497b8580d454d0b8a19a", async() => {
                BeginContext(1020, 7, true);
                WriteLiteral("&laquo;");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageindex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
                                            WriteLiteral(pageindex==1?1:pageindex-1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageindex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1031, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 33 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
         for(int i=pagestart;i<=pageend;i++){

#line default
#line hidden
            BeginContext(1095, 14, true);
            WriteLiteral("          <li ");
            EndContext();
            BeginContext(1111, 30, false);
#line 34 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
          Write(pageindex==i?"class=active":"");

#line default
#line hidden
            EndContext();
            BeginContext(1142, 17, true);
            WriteLiteral(">\r\n              ");
            EndContext();
            BeginContext(1159, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a24a4fe531f0466bbe2e042b3919ed79", async() => {
                BeginContext(1207, 1, false);
#line 35 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
                                                        Write(i);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageindex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
                                             WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageindex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1212, 19, true);
            WriteLiteral("\r\n          </li>\r\n");
            EndContext();
#line 37 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1242, 12, true);
            WriteLiteral("         <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1254, "\"", 1299, 1);
#line 38 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
WriteAttributeValue("", 1262, pageindex==pagecount?"disabled":"", 1262, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1300, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1315, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7336b438f79946788b5031ca2e55df64", async() => {
                BeginContext(1405, 7, true);
                WriteLiteral("&raquo;");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageindex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "/Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/Views/Note/Index.cshtml"
                                            WriteLiteral(pageindex==pagecount?pagecount:pageindex+1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageindex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1416, 36, true);
            WriteLiteral("\r\n        </li>\r\n\r\n    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NetNote.Models.Note>> Html { get; private set; }
    }
}
#pragma warning restore 1591
