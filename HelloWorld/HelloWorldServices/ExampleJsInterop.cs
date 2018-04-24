using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace HelloWorldServices
{
    public class ExampleJsInterop
    {
        public static string Prompt(string message)
        {
            return RegisteredFunction.Invoke<string>(
                "HelloWorldServices.ExampleJsInterop.Prompt",
                message);
        }
    }
}
