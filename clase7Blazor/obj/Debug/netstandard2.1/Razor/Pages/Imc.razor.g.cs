#pragma checksum "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\Imc.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "364fcfa5bae56a31a165c8f26f0c28ff2436bd14"
// <auto-generated/>
#pragma warning disable 1591
namespace clase7Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using clase7Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\_Imports.razor"
using clase7Blazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/imc")]
    public partial class Imc : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>IMC , calcula que tan roto estas</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\Imc.razor"
                 persona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\Imc.razor"
                                   calculoIMC

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "id", "nombre");
                __builder2.AddAttribute(8, "placeholder", "ingrese su nombre");
                __builder2.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\Imc.razor"
                           persona.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.nombre = __value, persona.nombre))));
                __builder2.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, " <br>\r\n    ");
                __Blazor.clase7Blazor.Pages.Imc.TypeInference.CreateInputNumber_0(__builder2, 13, 14, "peso", 15, "ingrese su peso", 16, 
#nullable restore
#line 6 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\Imc.razor"
                             persona.peso

#line default
#line hidden
#nullable disable
                , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.peso = __value, persona.peso)), 18, () => persona.peso);
                __builder2.AddMarkupContent(19, " <br>\r\n    ");
                __Blazor.clase7Blazor.Pages.Imc.TypeInference.CreateInputNumber_1(__builder2, 20, 21, "altura", 22, "ingrese altura", 23, 
#nullable restore
#line 7 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\Imc.razor"
                             persona.altura

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.altura = __value, persona.altura)), 25, () => persona.altura);
                __builder2.AddMarkupContent(26, " <br>\r\n    <input type=\"submit\" value=\"press!\">\r\n     \r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n\r\n\r\n");
            __builder.OpenComponent<clase7Blazor.Shared.Resultado>(28);
            __builder.AddAttribute(29, "imcCalculo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\Imc.razor"
                        resultadoIMC

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\Imc.razor"
                                             persona.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\dev\codigocodereactnetcore\reactnetcorecodigocode\clase7Blazor\Pages\Imc.razor"
      
    // codigo c#

    public Persona persona = new Persona();
    public string resultadoIMC { get; set; }

    public void calculoIMC()
    {

        Console.WriteLine("Calculando.....");
        Console.WriteLine(persona.peso);

        Console.WriteLine(persona.altura);

        persona.res = persona.peso / (persona.altura * persona.altura);
        resultadoIMC = "El valor del IMC: " +  (persona.res.ToString());
        Console.WriteLine(persona.res);

        if (persona.res < 18.5)
        {
            persona.img = "img/skinny.jpg";
        }
        else if (persona.res >= 18.5 && persona.res <= 24.99)
        {
            persona.img = "img/normal.jpg";
        }
        else
        {
            persona.img = "img/fat.jpg";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.clase7Blazor.Pages.Imc
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
