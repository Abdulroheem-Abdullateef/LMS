#pragma checksum "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9353e3bf62497a652605b72ca5178edc93273c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_Profile), @"mvc.1.0.view", @"/Views/Instructor/Profile.cshtml")]
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
#line 1 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\_ViewImports.cshtml"
using LearningManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\_ViewImports.cshtml"
using LearningManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9353e3bf62497a652605b72ca5178edc93273c", @"/Views/Instructor/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"253b9025da8ac75b4a4663180061fa51f4c7fe24", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Instructor_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LearningManagementSystem.DTOs.InstructorDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"
  
    Layout = "_InstructorLayout";
    ViewData["Title"] = "Instructor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<dl class=\"row\">\r\n    <dt class=\"com-sm-2\">\r\n        Instructor Name :\r\n    </dt>\r\n\r\n    <dd class=\"com-sm-10\">\r\n        ");
#nullable restore
#line 14 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"
   Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt class=\"com-sm-2\">\r\n        DepartmentName :\r\n    </dt>\r\n\r\n    <dd class=\"com-sm-10\">\r\n        ");
#nullable restore
#line 23 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"
   Write(Model.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt class=\"com-sm-2\">\r\n        CourseName :\r\n    </dt>\r\n\r\n    <dd class=\"com-sm-10\">\r\n        ");
#nullable restore
#line 31 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"
   Write(Model.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt class=\"com-sm-2\">\r\n        StudentNames :\r\n    </dt>\r\n\r\n");
#nullable restore
#line 38 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"
     foreach (var student in Model.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"
       Write(student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"
       Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"
       Write(student.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"
       Write(student.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 55 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Instructor\Profile.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</dl>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LearningManagementSystem.DTOs.InstructorDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
