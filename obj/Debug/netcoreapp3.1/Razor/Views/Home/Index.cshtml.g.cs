#pragma checksum "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f7d4ae5adf0c7681af26bbd80a22ce76cc148a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\_ViewImports.cshtml"
using HR_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\_ViewImports.cshtml"
using HR_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f7d4ae5adf0c7681af26bbd80a22ce76cc148a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390e6b011c80c8aacfb8cb7c82a5633b478e25dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #666666;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\Home\Index.cshtml"
  
    Layout = "LayoutLogin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67f7d4ae5adf0c7681af26bbd80a22ce76cc148a3749", async() => {
                WriteLiteral(@"
	<title>Login V18</title>
	<meta charset=""UTF-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<!--===============================================================================================-->	
	<link rel=""icon"" type=""image/png"" href=""images/icons/favicon.ico""/>
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/bootstrap/css/bootstrap.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""fonts/Linearicons-Free-v1.0.0/icon-font.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/cs");
                WriteLiteral(@"s"" href=""vendor/animate/animate.css"">
<!--===============================================================================================-->	
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/css-hamburgers/hamburgers.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/animsition/css/animsition.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/select2/select2.min.css"">
<!--===============================================================================================-->	
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/daterangepicker/daterangepicker.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""css/util.css"">
	<link rel=""stylesheet"" type=""text/css"" href=""css/main.css"">");
                WriteLiteral("\n<!--===============================================================================================-->\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67f7d4ae5adf0c7681af26bbd80a22ce76cc148a7007", async() => {
                WriteLiteral(@"
	
	<div class=""limiter"">
		<div class=""container-login100"">
			<div class=""wrap-login100"">
				<div class=""login100-form validate-form"">
					<span class=""login100-form-title p-b-10"">
						Login
					</span>
					<div class=""wrap-input100 validate-input"" data-validate = ""Valid email is required: ex@abc.xyz"">
						<input class=""input100"" type=""text"" name=""username"" id=""username1"">
						<span class=""focus-input100""></span>
						<span class=""label-input100"">Username</span>
					</div>
					
					<div class=""wrap-input100 validate-input"" data-validate=""Password is required"">
						<input class=""input100"" type=""password"" name=""password"" id=""password1"">
						<span class=""focus-input100""></span>
						<span class=""label-input100"">Password</span>
					</div>

					<div class=""flex-sb-m w-full p-t-3 p-b-32"">
						<div class=""contact100-form-checkbox"">
						</div>

						<div>
							<a href=""/Home/IndexForgotPassword"" class=""txt1"">
								Forgot Password?
							</a>
						</div>
					</div>
					<div class=""");
                WriteLiteral(@"container-login100-form-btn"">
						<button class=""login100-form-btn"" onclick=""javascript:LoginButton(this)"">
							Login As Admin
						</button>
					</div><br>
					<div class=""container-login100-form-btn"">
						<button class=""login100-form-btn"" onclick=""javascript:LoginEmp(this)"">
							Login As Employee
						</button>
					</div><br>
					<div class=""container-login100-form-btn"">
						<button class=""login100-form-btn"" onclick=""location.href='/ApplicantForm/Form'"">
							Applicant Form
						</button>
					</div><br>
				</div>

				<div class=""login100-more"" style=""background-image: url('images/bg-01.jpg');"">
				</div>
			</div>
		</div>
	</div>
<!--===============================================================================================-->
	<script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/animsition/js/animsition.min.js""></script>
<!--=========================");
                WriteLiteral(@"======================================================================-->
	<script src=""vendor/bootstrap/js/popper.js""></script>
	<script src=""vendor/bootstrap/js/bootstrap.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/select2/select2.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/daterangepicker/moment.min.js""></script>
	<script src=""vendor/daterangepicker/daterangepicker.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/countdowntime/countdowntime.js""></script>
<!--===============================================================================================-->
	<script src=""js/main.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<script>
function LoginButton(btn)
{
    var uname = document.getElementById(""username1"").value;
	var pass = document.getElementById(""password1"").value;
	location.href='/Home/IndexAdmin?username='+uname+'&password='+pass;
}
function LoginEmp(btn)
{
    var uname = document.getElementById(""username1"").value;
	var pass = document.getElementById(""password1"").value;
	location.href='/Home/IndexEmp?username='+uname+'&password='+pass;
}

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
