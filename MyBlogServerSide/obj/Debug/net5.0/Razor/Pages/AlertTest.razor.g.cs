#pragma checksum "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\Pages\AlertTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81546d55daf8fafd978ef5697f1f9552f93454be"
// <auto-generated/>
#pragma warning disable 1591
namespace MyBlogServerSide.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using MyBlogServerSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using MyBlogServerSide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using MyBlog.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using MyBlog.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Extensions.Head;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\Pages\AlertTest.razor"
using MyBlogServerSide.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/alerttest")]
    public partial class AlertTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MyBlogServerSide.Components.Alert>(0);
            __builder.AddAttribute(1, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MyBlogServerSide.Components.Alert.AlertStyle>(
#nullable restore
#line 4 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\Pages\AlertTest.razor"
              Alert.AlertStyle.Danger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    This is a test\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<MyBlogServerSide.Components.Alert>(5);
            __builder.AddAttribute(6, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MyBlogServerSide.Components.Alert.AlertStyle>(
#nullable restore
#line 8 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\Pages\AlertTest.razor"
              Alert.AlertStyle.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        This is another test.\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<MyBlogServerSide.Components.Alert>(10);
            __builder.AddAttribute(11, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MyBlogServerSide.Components.Alert.AlertStyle>(
#nullable restore
#line 14 "C:\Users\daguirre\source\repos\MyBlog\MyBlogServerSide\Pages\AlertTest.razor"
              Alert.AlertStyle.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
