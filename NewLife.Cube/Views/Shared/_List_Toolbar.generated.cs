﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\_List_Toolbar.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Views\Shared\_List_Toolbar.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_List_Toolbar.cshtml"
    using XCode;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Toolbar.cshtml")]
    public partial class _Views_Shared__List_Toolbar_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Toolbar_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\_List_Toolbar.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;

    var act = ViewBag.Action as String;
    if (act.IsNullOrEmpty()) { act = Url.Action("Index"); }

    var set = ViewBag.PageSetting as PageSetting;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"tableTools-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\r\n        <form");

WriteAttribute("action", Tuple.Create(" action=\"", 387), Tuple.Create("\"", 430)
            
            #line 15 "..\..\Views\Shared\_List_Toolbar.cshtml"
, Tuple.Create(Tuple.Create("", 396), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetFormAction(act))
            
            #line default
            #line hidden
, 396), false)
);

WriteLiteral(" method=\"post\"");

WriteLiteral(" role=\"form\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\Views\Shared\_List_Toolbar.cshtml"
            
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Shared\_List_Toolbar.cshtml"
             if (set.EnableAdd && this.Has(PermissionFlags.Insert))
            {
                var rv = page.GetRouteValue();
                
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\_List_Toolbar.cshtml"
           Write(Html.ActionLink("添加", "Add", rv, new { @class = "btn btn-success btn-sm" }.ToDictionary()));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\_List_Toolbar.cshtml"
                                                                                                           
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 21 "..\..\Views\Shared\_List_Toolbar.cshtml"
             if (set.EnableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group toolbar-batch\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 24 "..\..\Views\Shared\_List_Toolbar.cshtml"
               Write(Html.Partial("_List_Toolbar_Batch"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 26 "..\..\Views\Shared\_List_Toolbar.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"pull-right form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Shared\_List_Toolbar.cshtml"
           Write(Html.Partial("_List_Search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 29 "..\..\Views\Shared\_List_Toolbar.cshtml"
           Write(Html.Partial("_List_Toolbar_Search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 30 "..\..\Views\Shared\_List_Toolbar.cshtml"
           Write(Html.Partial("_List_Toolbar_Adv"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n");

            
            #line 35 "..\..\Views\Shared\_List_Toolbar.cshtml"
 if (set.EnableSelect)
{

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        $(function () {\r\n            var $toolbarContext = $(\'.tool" +
"bar-batch\'),\r\n                $batchButtons = $(\'button[data-action=\"action\"], i" +
"nput[data-action=\"action\"]\'), //button, input=button, a 3种类型都可以\r\n               " +
" $table = $(\'.table\'),\r\n                $keys = $(\'input[name=\"keys\"]\', $table);" +
"\r\n\r\n            $table.on(\'click\', \'#chkAll\', function () {\r\n                // " +
"全选\r\n                $keys.prop(\'checked\', this.checked);\r\n                // 启用禁" +
"用批量操作区\r\n                $batchButtons.prop(\'disabled\', !this.checked);\r\n        " +
"    });\r\n\r\n            $table.on(\'click.checked\', \'tbody input[name=\"keys\"]\', fu" +
"nction (e) {\r\n                //页面中所有的checkbox\r\n                var allbox = $ta" +
"ble.find(\'tbody :checkbox[name=\"keys\"]\');\r\n                //页面中所选中的checkbox\r\n  " +
"              var selecteds = $table.find(\'tbody :checkbox:checked[name=\"keys\"]\'" +
");\r\n                if (selecteds.length > 0) {\r\n                    // 启用禁用批量操作" +
"区\r\n                    $batchButtons.prop(\'disabled\', false);\r\n                 " +
"   //需要判断当前页面所有行的checkbox是否都选中，以此来决定是否需要改变checkbox#chkAll 的状态\r\n                 " +
"   if (allbox.length == selecteds.length) {\r\n                        $table.find" +
"(\'#chkAll\').prop(\'checked\', true);\r\n                    } else {\r\n              " +
"          $table.find(\'#chkAll\').prop(\'checked\', false);\r\n                    }\r" +
"\n                }\r\n                else {\r\n                    $batchButtons.pr" +
"op(\'disabled\', true);\r\n                    $table.find(\'#chkAll\').prop(\'checked\'" +
", false);\r\n                }\r\n            });\r\n        })\r\n    </script>\r\n");

            
            #line 73 "..\..\Views\Shared\_List_Toolbar.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
