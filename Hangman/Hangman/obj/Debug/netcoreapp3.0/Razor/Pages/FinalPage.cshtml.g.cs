#pragma checksum "C:\Users\uvojt\OneDrive\Documents\School\P4\Webové_aplikace\ASP.NET\.NET\Hangman\Hangman\Pages\FinalPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf70e366f67e923c6af57c3f6c7953c8d4ad5766"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hangman.Pages.Pages_FinalPage), @"mvc.1.0.razor-page", @"/Pages/FinalPage.cshtml")]
namespace Hangman.Pages
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
#line 1 "C:\Users\uvojt\OneDrive\Documents\School\P4\Webové_aplikace\ASP.NET\.NET\Hangman\Hangman\Pages\_ViewImports.cshtml"
using Hangman;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf70e366f67e923c6af57c3f6c7953c8d4ad5766", @"/Pages/FinalPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef66bd0208ee97953e5ed7f8cfaa3b5deb6184c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FinalPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\uvojt\OneDrive\Documents\School\P4\Webové_aplikace\ASP.NET\.NET\Hangman\Hangman\Pages\FinalPage.cshtml"
  
    ViewData["Title"] = "FinalPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf70e366f67e923c6af57c3f6c7953c8d4ad57663623", async() => {
                WriteLiteral("\r\n    <div>\r\n");
#nullable restore
#line 9 "C:\Users\uvojt\OneDrive\Documents\School\P4\Webové_aplikace\ASP.NET\.NET\Hangman\Hangman\Pages\FinalPage.cshtml"
          
            if (Model.hg.data.Mistakes != 10)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h2>You won!</h2>\r\n");
#nullable restore
#line 13 "C:\Users\uvojt\OneDrive\Documents\School\P4\Webové_aplikace\ASP.NET\.NET\Hangman\Hangman\Pages\FinalPage.cshtml"
            }
            if (Model.hg.data.Mistakes == 10)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h2>You were hanged!</h2>\r\n");
#nullable restore
#line 17 "C:\Users\uvojt\OneDrive\Documents\School\P4\Webové_aplikace\ASP.NET\.NET\Hangman\Hangman\Pages\FinalPage.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button class=\"bg-success\" type=\"submit\">PLAY AGAIN</button>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hangman.Pages.FinalPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hangman.Pages.FinalPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hangman.Pages.FinalPageModel>)PageContext?.ViewData;
        public Hangman.Pages.FinalPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
