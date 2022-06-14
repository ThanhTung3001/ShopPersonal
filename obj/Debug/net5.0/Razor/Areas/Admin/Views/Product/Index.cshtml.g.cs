#pragma checksum "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bece5d2b048630eaa62c58c0af5e8565da1f6ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bece5d2b048630eaa62c58c0af5e8565da1f6ee", @"/Areas/Admin/Views/Product/Index.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h3>Product Page</h3>
<div class=""row justify-content-end"">
    <div class=""col-sm-3 "">
        <button type=""button"" id=""modalAdd"" class=""btn btn-primary btn-lg"" data-toggle=""modal"" data-target=""#modal_add"">
            Add product
        </button>
    </div>
</div>
<table class=""table table-striped table-inverse table-responsive"">
    <thead class=""thead-inverse"">
        <tr>
            <th>Id</th>
            <th>Product Name</th>
            <th>Create Date</th>
            <th>Price</th>
            <th>Description</th>
            <th>Handle</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
         foreach (var item in ViewBag.Products)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
               Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                     <a");
            BeginWriteAttribute("href", " href=\"", 1187, "\"", 1224, 2);
            WriteAttributeValue("", 1194, "/Admin/Product/Get?id=", 1194, 22, true);
#nullable restore
#line 44 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 1216, item.Id, 1216, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a>\r\n                    <button class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1312, "\"", 1345, 3);
            WriteAttributeValue("", 1322, "DeteteProduct(", 1322, 14, true);
#nullable restore
#line 45 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 1336, item.Id, 1336, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1344, ")", 1344, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<div id=""modalArea"">
    <!-- Button trigger modal -->


    <!-- Modal -->
    <div class=""modal fade"" id=""modal_add"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modelTitleId""
        aria-hidden=""true"">
        <div class=""modal-dialog"" style=""min-width:800px ;"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle""> Add product</h5>
                    <button type=""button"" class=""btn close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col-sm-8 md-6"">
                            <div class=""form-group"">
                                <label");
            BeginWriteAttribute("for", " for=\"", 2357, "\"", 2363, 0);
            EndWriteAttribute();
            WriteLiteral(">Product name</label>\r\n                                <input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 2437, "\"", 2444, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"productName\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2483, "\"", 2497, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                                    aria-describedby=""helpId"">
                                <small id=""helpId"" class=""text-muted"">*</small>
                            </div>
                        </div>
                        <div class=""col-sm-8 md-6"">
                            <div class=""form-group"">
                                <label");
            BeginWriteAttribute("for", " for=\"", 2858, "\"", 2864, 0);
            EndWriteAttribute();
            WriteLiteral(">Price</label>\r\n                                <input type=\"number\"");
            BeginWriteAttribute("name", " name=\"", 2933, "\"", 2940, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"productPrice\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2980, "\"", 2994, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                                    aria-describedby=""helpId"">
                                <small id=""helpId"" class=""text-muted"">VND</small>
                            </div>
                        </div>
                         <div class=""col-sm-8 md-6"">
                            <div class=""form-group"">
                              <label");
            BeginWriteAttribute("for", " for=\"", 3356, "\"", 3362, 0);
            EndWriteAttribute();
            WriteLiteral(">Category</label>\r\n                              <select class=\"form-control\"");
            BeginWriteAttribute("name", " name=\"", 3440, "\"", 3447, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"categorySelect\">\r\n");
#nullable restore
#line 89 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
                                  foreach(var category in ViewBag.Categories){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <option");
            BeginWriteAttribute("value", " value=\"", 3595, "\"", 3615, 1);
#nullable restore
#line 90 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 3603, category.Id, 3603, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
                                                             Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 91 "C:\Users\tunglvt\source\repos\WebApp\WebApp\Areas\Admin\Views\Product\Index.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                              </select>
                            </div>
                        </div>
                         <div class=""col-sm-12 md-6"">
                            <div class=""form-group"">
                                <label");
            BeginWriteAttribute("for", " for=\"", 3934, "\"", 3940, 0);
            EndWriteAttribute();
            WriteLiteral(">Attachments</label>\r\n                                <input type=\"file\" multiple");
            BeginWriteAttribute("name", " name=\"", 4022, "\"", 4029, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"files\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4062, "\"", 4076, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                                    aria-describedby=""helpId"">
                                <small id=""helpId"" class=""text-muted"">File Image</small>
                            </div>
                        </div>
                         <div class=""col-sm-12 md-6"">
                           <div class=""form-group"">
                             <label");
            BeginWriteAttribute("for", " for=\"", 4444, "\"", 4450, 0);
            EndWriteAttribute();
            WriteLiteral(">Description</label>\r\n                           <textarea  class=\"form-control\"");
            BeginWriteAttribute("name", " name=\"", 4531, "\"", 4538, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""description"" cols=""30"" rows=""10""></textarea>
                           </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" onclick=""addProduct()"">Save</button>
                </div>
            </div>
        </div>
    </div>

</div>
<div id=""modalUpdate"">

</div>
<script>
       function DeteteProduct (id){
    
        fetch(""/Admin/Product/Delete?id=""+id,{method:""DELETE""})
        .then(rs=>{
            if(rs.status==200){
                alert(""Delete Success"");
                location.reload();
            }else{
                alert(""Delete fail"");
            }
        })
    }
    document.querySelector(""#modalAdd"").addEventListener('click', (event) => {
        $(""#modal_add"").modal('show')
    })
    const addPr");
            WriteLiteral(@"oduct = ()=>{
        let name = document.querySelector(""#productName"").value;
        let price = document.querySelector(""#productPrice"").value;
        let description = document.querySelector(""#description"").value;
        let files = document.querySelector(""#files"").files;
        let CategoryId =document.querySelector(""#categorySelect"").value;
        let data =  {
            CategoryId:CategoryId,
            ProductName:name,
            Description:description,
            Price:price
        }
        let form = new FormData();
        for(let i = 0; i<files.length;i++){
            form.append(""files"",files[i]);
        }
        form.append(""product"",JSON.stringify(data));

        fetch(""/Admin/Product/uploadProduct"",{
             method: 'POST',
             body: form
        })
        .then(data=>{
            if(data.status==200){
                alert(""Add Success!"")
                location.reload();
            }else{
                alert(""Add fail"")
        ");
            WriteLiteral(@"    }
        })
    }
    const renderModalUpdate = (data)=>{
        let html =`
          <div class=""modal fade"" id=""modal_update"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modelTitleId""
        aria-hidden=""true"">
        <div class=""modal-dialog"" style=""min-width:800px ;"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle""> Add product</h5>
                    <button type=""button"" class=""btn close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col-sm-8 md-6"">
                            <div class=""form-group"">
                                <label for="""">Product name</label>
                                <input type=""text"" value=""${data");
            WriteLiteral(@".productName}"" name="""" id=""productName"" class=""form-control"" placeholder=""""
                                    aria-describedby=""helpId"">
                                <small id=""helpId"" class=""text-muted"">*</small>
                            </div>
                        </div>
                        <div class=""col-sm-8 md-6"">
                            <div class=""form-group"">
                                <label for="""">Price</label>
                                <input type=""number"" value=""${data.price}"" name="""" id=""productPrice"" class=""form-control"" placeholder=""""
                                    aria-describedby=""helpId"">
                                <small id=""helpId"" class=""text-muted"">VND</small>
                            </div>
                        </div>
                         <div class=""col-sm-12 md-6"">
                            <div class=""form-group"">
                                <label for="""">Attachments</label>
                                <inpu");
            WriteLiteral(@"t type=""file"" multiple name="""" id=""files"" class=""form-control"" placeholder=""""
                                    aria-describedby=""helpId"">
                                <small id=""helpId"" class=""text-muted"">File Image</small>
                            </div>
                        </div>
                         <div class=""col-sm-12 md-6"">
                           <div class=""form-group"">
                             <label for="""">Description</label>
                           <textarea  class=""form-control"" name="""" id=""description"" cols=""30"" rows=""10"">${data.description}</textarea>
                           </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" onclick=""UpdateProduct()"">Save</button>
                </div>
            </di");
            WriteLiteral("v>\r\n        </div>\r\n    </div>\r\n        `;\r\n        document.querySelector(\"#modalUpdate\").innerHTML = html;\r\n         $(\"#modal_update\").modal(\'show\')\r\n    }\r\n  \r\n    \r\n</script>");
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
