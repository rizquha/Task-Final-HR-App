#pragma checksum "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1931ec9cb6f8e2c8f7dfb070909fcd77ca413d5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveRequest_Detail), @"mvc.1.0.view", @"/Views/LeaveRequest/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1931ec9cb6f8e2c8f7dfb070909fcd77ca413d5c", @"/Views/LeaveRequest/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390e6b011c80c8aacfb8cb7c82a5633b478e25dc", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveRequest_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>


<!------ Include the above in your HEAD tag ---------->
<style>
    body{
		background: linear-gradient(90deg, #e8e8e8 50%, #3d009e 50%);
	}
	.portfolio{
		padding:6%;
		text-align:center;
	}
	.heading{
		background: #fff;
		padding: 1%;
		text-align: left;
		box-shadow: 0px 0px 4px 0px #545b62;
	}
	.heading img{
		width: 10%;
	}
	.bio-info{
		padding: 5%;
		background:#fff;
		box-shadow: 0px 0px 4px 0px #b0b3b7;
	}
	.name{
		font-family: 'Charmonman', cursive;
		font-weight:600;
	}
	.bio-image{
		text-align:center;
	}
	.bio-image img{
		border-radius:50%;
	}
	.bio-content{
		text-align:left;
	}
	.bio-content p{
		font-weight:600;
		font-size:30px;
	}
    .dropdown {
  position: relative;
  display: inline-block;
}

.dropdown-co");
            WriteLiteral("ntent {\n  display: none;\n  position: absolute;\n  background-color: #f1f1f1;\n  min-width: 160px;\n  overflow: auto;\n  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);\n  z-index: 1;\n}\n.show {display: block;}\n</style>\n");
#nullable restore
#line 62 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
  
    Layout="_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"" id=""container-wrapper"">
  <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Leave Request</h1>
      <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a>Home / Leave Request / Detail</a></li>
      </ol>
  </div>
</div>
");
#nullable restore
#line 73 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
  
var details = ViewBag.details;
foreach(var i in details)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container portfolio"">
	<div class=""row"">
		<div class=""col-md-12"">
			<div class=""heading"" data-toggle=""collapse"" data-target=""#profile"" aria-expanded=""true""
            aria-controls=""collapsePage"">	
                <img src=""https://image.ibb.co/cbCMvA/logo.png"" />
                <label class=""text-right""><b>Profile</b></label>
			</div>
		</div>	
	</div>
    <div class=""row"">
		<div class=""col-md-12"">
			<div class=""heading"" data-toggle=""collapse"" data-target=""#occupation"" aria-expanded=""true""
            aria-controls=""collapsePage"">	
                <img src=""https://image.ibb.co/cbCMvA/logo.png"" />
                <label class=""text-right""><b>Detail Request</b></label>
			</div>
		</div>	
	</div>
	<div class=""bio-info collapse"" id=""profile"" aria-labelledby=""headingPage"" data-parent=""#accordionSidebar"">
		<div class=""row"">
			<div class=""col-md-6"">
				<div class=""row"">
					<div class=""col-md-12"">
						<div class=""bio-image"">
							<img");
            BeginWriteAttribute("src", " src=\"", 2620, "\"", 2635, 2);
#nullable restore
#line 102 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
WriteAttributeValue("", 2626, i.Image, 2626, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2634, "", 2635, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:50%;width:250px;height:300px;\" alt=\"image\" />\n\t\t\t\t\t\t</div>\t\t\t\n\t\t\t\t\t</div>\n\t\t\t\t</div>\t\n\t\t\t</div>\n\t\t\t<div class=\"col-md-6\">\n\t\t\t\t<div class=\"bio-content\">\n\t\t\t\t\t<h1>Hi there, I\'m ");
#nullable restore
#line 109 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
                                 Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t\t\t\t<h6>Email : ");
#nullable restore
#line 110 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
                           Write(i.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\t\t\t\t\t<h6>Phone : ");
#nullable restore
#line 111 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
                           Write(i.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\t\t\t\t\t<h6>Position : ");
#nullable restore
#line 112 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
                              Write(i.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\t\t\t\t\t<h6>Departement : ");
#nullable restore
#line 113 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
                                 Write(i.Departement);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
				</div>
			</div>
		</div>	
	</div>
    <div class=""bio-info collapse"" id=""occupation"" aria-labelledby=""headingPage"" data-parent=""#accordionSidebar"">
		<div class=""row"">
			<div class=""col-md-6"">
				<div class=""row"">
					<div class=""col-md-12"">
						<div class=""bio-image"">
							<img");
            BeginWriteAttribute("src", " src=\"", 3279, "\"", 3293, 1);
#nullable restore
#line 124 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
WriteAttributeValue("", 3285, i.Image, 3285, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:50%;width:250px;height:300px;\" alt=\"image\" />\n\t\t\t\t\t\t</div>\t\t\t\n\t\t\t\t\t</div>\n\t\t\t\t</div>\t\n\t\t\t</div>\n\t\t\t<div class=\"col-md-6\">\n\t\t\t\t<div class=\"bio-content\">\n                    <h1>Hi there, I\'m ");
#nullable restore
#line 131 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
                                 Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t\t\t\t<h6>Leave Date : ");
#nullable restore
#line 132 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
                                Write(i.LeaveDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\t\t\t\t\t<h6>Reason : ");
#nullable restore
#line 133 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
                            Write(i.reason);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\t\t\t\t\t<h6>Status : ");
#nullable restore
#line 134 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
                            Write(i.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t</div>\t\n\t</div>\n</div>\n");
#nullable restore
#line 140 "D:\Users\bsi50129\.vscode\Task-Final-HR-App\Views\LeaveRequest\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
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
