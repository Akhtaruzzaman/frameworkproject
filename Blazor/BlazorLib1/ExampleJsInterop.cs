using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorLib1
{
    public class ExampleJsInterop
    {
        public static string Prompt(string message)
        {
            return RegisteredFunction.Invoke<string>(
                "BlazorLib1.ExampleJsInterop.Prompt",
                message);
        }
    }
}
