#pragma checksum "D:\zhaoxi\Architect\20200619Architect01Course048Docker\Zhaoxi.AspNetCore31.DockerProject\Zhaoxi.AspNetCore31.DockerProject\Views\Home\IndexRedis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b0e30733eb14c7053365a7158c151e8993a4d3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexRedis), @"mvc.1.0.view", @"/Views/Home/IndexRedis.cshtml")]
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
#line 1 "D:\zhaoxi\Architect\20200619Architect01Course048Docker\Zhaoxi.AspNetCore31.DockerProject\Zhaoxi.AspNetCore31.DockerProject\Views\_ViewImports.cshtml"
using Zhaoxi.AspNetCore31.DockerProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\zhaoxi\Architect\20200619Architect01Course048Docker\Zhaoxi.AspNetCore31.DockerProject\Zhaoxi.AspNetCore31.DockerProject\Views\_ViewImports.cshtml"
using Zhaoxi.AspNetCore31.DockerProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0e30733eb14c7053365a7158c151e8993a4d3d", @"/Views/Home/IndexRedis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3fa288e422687cd1ad7e598aea699e3dc95a5af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexRedis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\zhaoxi\Architect\20200619Architect01Course048Docker\Zhaoxi.AspNetCore31.DockerProject\Zhaoxi.AspNetCore31.DockerProject\Views\Home\IndexRedis.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">IndexRedis Welcome2222</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n<h3>ViewTime:");
#nullable restore
#line 9 "D:\zhaoxi\Architect\20200619Architect01Course048Docker\Zhaoxi.AspNetCore31.DockerProject\Zhaoxi.AspNetCore31.DockerProject\Views\Home\IndexRedis.cshtml"
        Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h2>??????Action?????????");
#nullable restore
#line 10 "D:\zhaoxi\Architect\20200619Architect01Course048Docker\Zhaoxi.AspNetCore31.DockerProject\Zhaoxi.AspNetCore31.DockerProject\Views\Home\IndexRedis.cshtml"
          Write(base.ViewBag.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>DistributedCacheNow?????????");
#nullable restore
#line 11 "D:\zhaoxi\Architect\20200619Architect01Course048Docker\Zhaoxi.AspNetCore31.DockerProject\Zhaoxi.AspNetCore31.DockerProject\Views\Home\IndexRedis.cshtml"
                     Write(base.ViewBag.DistributedCacheNow);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
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
